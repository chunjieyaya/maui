using System.Threading;
using System.Threading.Tasks;
using Tizen.Location;

namespace Microsoft.Maui.Essentials.Implementations
{
	public partial class GeolocationImplementation : IGeolocation
	{
		Location lastKnownLocation = new Location();

		public Task<Location> GetLastKnownLocationAsync() => Task.FromResult(lastKnownLocation);

		public async Task<Location> GetLocationAsync(GeolocationRequest request, CancellationToken cancellationToken)
		{
			await Permissions.EnsureGrantedAsync<Permissions.LocationWhenInUse>();

			Locator service = null;
			var gps = Platform.GetFeatureInfo<bool>("location.gps");
			var wps = Platform.GetFeatureInfo<bool>("location.wps");
			if (gps)
			{
				if (wps)
					service = new Locator(LocationType.Hybrid);
				else
					service = new Locator(LocationType.Gps);
			}
			else
			{
				if (wps)
					service = new Locator(LocationType.Wps);
				else
					service = new Locator(LocationType.Passive);
			}

			var tcs = new TaskCompletionSource<bool>();

			cancellationToken = Utils.TimeoutToken(cancellationToken, request.Timeout);
			cancellationToken.Register(() =>
			{
				service?.Stop();
				tcs.TrySetResult(false);
			});

			double KmToMetersPerSecond(double km) => km * 0.277778;
			service.LocationChanged += (s, e) =>
			{
				if (e.Location != null)
				{
					lastKnownLocation.Accuracy = e.Location.Accuracy;
					lastKnownLocation.Altitude = e.Location.Altitude;
					lastKnownLocation.Course = e.Location.Direction;
					lastKnownLocation.Latitude = e.Location.Latitude;
					lastKnownLocation.Longitude = e.Location.Longitude;
					lastKnownLocation.Speed = KmToMetersPerSecond(e.Location.Speed);
					lastKnownLocation.Timestamp = e.Location.Timestamp;
				}
				service?.Stop();
				tcs.TrySetResult(true);
			};
			service.Start();

			await tcs.Task;

			return lastKnownLocation;
		}
	}
}
