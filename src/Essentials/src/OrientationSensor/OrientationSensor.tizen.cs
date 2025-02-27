using Tizen.Sensor;
using TizenRotationVectorSensor = Tizen.Sensor.RotationVectorSensor;

namespace Microsoft.Maui.Essentials.Implementations
{
	public partial class OrientationSensorImplementation : IOrientationSensor
	{
		static TizenRotationVectorSensor DefaultSensor
			=> (TizenRotationVectorSensor)Platform.GetDefaultSensor(SensorType.OrientationSensor);

		bool PlatformIsSupported
			=> TizenRotationVectorSensor.IsSupported;

		TizenRotationVectorSensor sensor;

		void PlatformStart(SensorSpeed sensorSpeed)
		{
			sensor = DefaultSensor;

			sensor.Interval = sensorSpeed.ToPlatform();
			sensor.DataUpdated += DataUpdated;
			sensor.Start();
		}

		void PlatformStop()
		{
			sensor.DataUpdated -= DataUpdated;
			sensor.Stop();
			sensor = null;
		}

		void DataUpdated(object sender, RotationVectorSensorDataUpdatedEventArgs e)
		{
			RaiseReadingChanged(new OrientationSensorData(e.X, e.Y, e.Z, e.W));
		}
	}
}
