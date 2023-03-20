namespace WindowsFormsApp3
{
	public class TelemetryData
	{
    		// Mavlink data
    		public float Altitude { get; set; }
    		public float Speed { get; set; }
    		public float Pitch { get; set; }
    		public float Roll { get; set; }
    		public float Yaw { get; set; }

   		// Network data
    		public string ConnectionIP { get; set; }
    		public string SubnetMask { get; set; }
   		public float Ping { get; set; }
    		public int RefreshRate { get; set; }
	}

	public void UpdateTelemetryData(float altitude, float speed, float pitch, float roll, float yaw)
	{
    		Altitude = altitude;
    		Speed = speed;
    		Pitch = pitch;
    		Roll = roll;
    		Yaw = yaw;
	}
}

