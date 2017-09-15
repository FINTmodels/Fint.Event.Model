namespace Fint.Event.Model
{
    /// <summary>
    /// The Status Enum indicates what step the { @link Event } is at.The steps can be:
    /// <ul>
    ///  <li>{@link #NEW}</li>
    ///  <li>{@link #DOWNSTREAM_QUEUE}</li>
    ///  <li>{@link #DELIVERED_TO_ADAPTER}</li> 
    ///  <li>{@link #ADAPTER_ACCEPTED}</li> 
    ///  <li>{@link #ADAPTER_NOT_CONFIRMED}</li> 
    ///  <li>{@link #UNABLE_TO_DELIVER}</li>
    ///  <li>{@link #NO_RESPONSE_FROM_ADAPTER}</li> 
    ///  <li>{@link #ADAPTER_REJECTED}</li> 
    ///  <li>{@link #ADAPTER_RESPONSE}</li> 
    ///  <li>{@link #UPSTREAM_QUEUE}</li>
    ///  <li>{@link #TEMP_UPSTREAM_QUEUE}</li>
    ///  <li>{@link #SENT_TO_CLIENT}</li>
    ///  <li>{@link #CACHE}</li>
    ///  <li>{@link #CACHE_RESPONSE}</li>
    ///  <li>{@link #ERROR}</li> 
    ///  <li>{@link #ADAPTER_RESPONSE_ORPHANED}</li> 
    /// </ul>
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Indicates that the event is just created.
        /// </summary> 
        NEW = 10,

        /// <summary>
        /// Indicates that the event is put in the downstream event queue.
        /// </summary> 
        DOWNSTREAM_QUEUE = 11,

        /// <summary>
        /// Indicates that the event is delivered to the adapter, but we don't know if
        /// the provider will process the event yet.
        /// </summary>
        DELIVERED_TO_ADAPTER = 12,

        /// <summary>
        /// Indicates that the event is accepted and understood by the adapter. The adapter will
        /// process the event.
        /// </summary>
        ADAPTER_ACCEPTED = 13,

        /// <summary>
        /// Indicates that we never received a confirmation from the adapter after delivering it according
        /// to the TTL value.
        /// </summary>
        ADAPTER_NOT_CONFIRMED = 103,

        /// <summary>
        /// Indicates that the event could not be delivered to the provider.
        /// </summary>
        UNABLE_TO_DELIVER = 104,

        /// <summary>
        /// Indicates that the event is delivered to the adapter, but the adapter never responded
        /// according to the TTL value.
        /// </summary>
        NO_RESPONSE_FROM_ADAPTER = 101,

        /// <summary>
        /// Indicates that the adapter recieved the event, but could not process it. Reasons could be:
        /// - could not understand the event
        /// - could not communicate with the source system
        /// </summary>
        ADAPTER_REJECTED = 102,

        /// <summary>
        /// Indicates that the event is the response from the adapter.
        /// </summary>
        ADAPTER_RESPONSE = 14,

        /// <summary>
        /// Indicates that the event is put in the upstream event queue.
        /// </summary>
        UPSTREAM_QUEUE = 15,

        /// <summary>
        /// Indicates that the event is put int the temp upstream event queue.
        /// </summary>
        TEMP_UPSTREAM_QUEUE = 16,

        /// <summary>
        /// Indicates that the event is sent back to the client. This is the last step for the event.
        /// </summary>
        SENT_TO_CLIENT = 49,

        /// <summary>
        /// Indicates that the event is delivered to the cache service.
        /// </summary>
        CACHE = 50,

        /// <summary>
        /// Indicates that the event is the response form the cache service.
        /// </summary>
        CACHE_RESPONSE = 51,

        /// <summary>
        /// Indicates that something went wrong with the event. The message field should be set when this
        /// status is set.
        /// </summary>
        ERROR = 1000,

        /// <summary>
        /// Indicates that we cannot find any corresponding events.
        /// </summary>
        ADAPTER_RESPONSE_ORPHANED = 100

    }
}
