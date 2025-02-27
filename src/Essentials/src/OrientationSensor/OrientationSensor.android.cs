using System;
using Android.Hardware;
using Android.Runtime;

namespace Microsoft.Maui.Essentials.Implementations
{
	public partial class OrientationSensorImplementation : IOrientationSensor
	{
		bool PlatformIsSupported =>
			Platform.SensorManager?.GetDefaultSensor(SensorType.RotationVector) != null;

		OrientationSensorListener listener;
		Sensor orientationSensor;

		void PlatformStart(SensorSpeed sensorSpeed)
		{
			var delay = sensorSpeed.ToPlatform();

			listener = new OrientationSensorListener(RaiseReadingChanged);
			orientationSensor = Platform.SensorManager.GetDefaultSensor(SensorType.RotationVector);
			Platform.SensorManager.RegisterListener(listener, orientationSensor, delay);
		}

		void PlatformStop()
		{
			if (listener == null || orientationSensor == null)
				return;

			Platform.SensorManager.UnregisterListener(listener, orientationSensor);
			listener.Dispose();
			listener = null;
		}
	}

	class OrientationSensorListener : Java.Lang.Object, ISensorEventListener
	{
		internal OrientationSensorListener(Action<OrientationSensorData> callback)
		{
			Callback = callback;
		}

		readonly Action<OrientationSensorData> Callback;

		void ISensorEventListener.OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
		{
		}

		void ISensorEventListener.OnSensorChanged(SensorEvent e)
		{
			var count = e?.Values?.Count ?? 0;
			if (count < 3)
				return;

			OrientationSensorData? data;

			// Docs: https://developer.android.com/reference/android/hardware/SensorEvent#sensor.type_rotation_vector-:
			// values[3], originally optional, will always be present from SDK Level 18 onwards. values[4] is a new value that has been added in SDK Level 18.

			if (count < 4)
				data = new OrientationSensorData(e.Values[0], e.Values[1], e.Values[2], -1);
			else
				data = new OrientationSensorData(e.Values[0], e.Values[1], e.Values[2], e.Values[3]);

			Callback?.Invoke(data.Value);
		}
	}
}
