namespace Fint.Event.Model
{

    /// <summary>
    /// The response status indicates the result of the event from the adapter.
    /// </summary>
    public enum ResponseStatus
    {
        /// <summary>
        /// The event request was accepted. For example the update of the resource was successful.
        /// </summary>
        ACCEPTED,

        /// <summary>
        /// The event request was rejected. For example that the adapter does not allow the 
        /// update of a resource.
        /// </summary>
        REJECTED,

        /// <summary>
        /// An error happened during processing of the event, for example that the db that
        /// the adapter connects to is down.
        /// </summary>
        ERROR,

        /// <summary>
        /// The requested action results in a conflict, for example that an event tries to
        /// update a value that another event has already updated.
        /// </summary>
        CONFLICT
    }

}