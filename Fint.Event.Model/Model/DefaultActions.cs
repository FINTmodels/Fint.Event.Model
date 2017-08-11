using System;
using System.Collections.Generic;

namespace Fint.Event.Model
{
    public enum DefaultActions
    {
        /// <summary>
        /// Tells the adapter to check communication with application and that the adapter can perform necessary actions {@link no.fint.event.model.health.Health}
        /// </summary>
        HEALTH,

        /// <summary>
        /// Registers orgId in provider
        /// </summary>
        REGISTER_ORG_ID
    }
}
