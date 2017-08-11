using System;
namespace Fint.Event.Model.Health
{
    public class Health
    {
        /// <summary>
        /// The current component
        /// </summary>
        public string Component { get; set; }

        /// <summary>
        /// Status for the current step of the health check
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// When the instance of the Health object was created
        /// </summary>
        public long Timestamp { get; set; }

        public Health()
        {
            Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
        }

        public Health(string status)
        {
            Status = status;
            Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
        }

        public Health(HealthStatus healthStatus) : this(healthStatus.ToString()) { }

        public Health(string component, string status)
        {
            Status = status;
            Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
            Component = component;
        }

        public Health(string component, HealthStatus healthStatus) : this(component, healthStatus.ToString()) { }

        public Health(String component, HealthStatus healthStatus, long timestamp)
        {
            Component = component;
            Status = healthStatus.ToString();
            Timestamp = timestamp;
        }

		/// <summary>
		/// Creates a ISO-8601 (2011-12-03T10:15:30Z) representation of the timestamp value.
		/// </summary>
		/// <returns>The ISO-8601 formatted time</returns>
		public string GetTime()
        {
            return DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }
    }
}
