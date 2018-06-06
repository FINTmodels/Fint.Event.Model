namespace Fint.Event.Model
{
    /// <summary>
    /// Operation to be performed using provided data.
    /// </summary>
    public enum Operation
    {
        /// <summary>
        /// Request data validation.  No information is stored or modified.
        /// </summary>
        VALIDATE,

        /// <summary>
        /// Request data creation.  A new information entity is to be created.
        /// </summary>
        CREATE,

        /// <summary>
        /// Request data.  Return existing information entity.
        /// </summary>
        READ,

        /// <summary>
        /// Request data modification.  An existing information entity is to be modified.
        /// </summary>
        UPDATE,

        /// <summary>
        /// Request data deletion.  An existing information entity is to be removed.
        /// </summary>
        DELETE

    }
}