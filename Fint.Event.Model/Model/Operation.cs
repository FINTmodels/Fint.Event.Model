namespace Fint.Event.Model
{
    public enum Operation
    {
        /**
         * Request data validation.  No information is stored or modified.
         */
        VALIDATE,
        /**
         * Request data creation.  A new information entity is to be created.
         */
        CREATE,
        /**
         * Request data.  Return existing information entity.
         */
        READ,
        /**
         * Request data modification.  An existing information entity is to be modified.
         */
        UPDATE,
        /**
         * Request data deletion.  An existing information entity is to be removed.
         */
        DELETE

    }
}