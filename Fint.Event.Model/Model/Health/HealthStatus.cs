using System;
namespace Fint.Event.Model.Health
{
    public enum HealthStatus
    {
		/// <summary>
		/// The health check has been sent from the consumer to the provider
		/// </summary>
		SENT_FROM_CONSUMER_TO_PROVIDER,

        /// <summary>
        /// The health check was received in the provider from the consumer
		/// </summary>
		RECEIVED_IN_PROVIDER_FROM_CONSUMER,

		/// <summary>
		/// The health check was sent from the provider to the adapter
		/// </summary>
		SENT_FROM_PROVIDER_TO_ADAPTER,

		/// <summary>
		/// The health check was received in provider from the adapter
		/// </summary>
		RECEIVED_IN_PROVIDER_FROM_ADAPTER,

		/// <summary>
		/// The health check was sent from the provider to the consumer
		/// </summary>
		SENT_FROM_PROVIDER_TO_CONSUMER,

		/// <summary>
		/// The health check was received in the consumer from the provider
		/// </summary>
		RECEIVED_IN_CONSUMER_FROM_PROVIDER,

		/// <summary>
		/// Indicates that the adapter can communicate with the application and everything should work as expected
		/// </summary>
		APPLICATION_HEALTHY,

		/// <summary>
		/// Indicates that there are problems with the communication from the adapter to the application
		/// </summary>
		APPLICATION_UNHEALTHY
    }
}
