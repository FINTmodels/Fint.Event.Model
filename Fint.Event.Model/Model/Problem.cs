namespace Fint.Event.Model
{

    /// <summary>
    /// Contains information on a semantic problem with the data submitted with the event.
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// The name of the field the problem relates to.  
        /// Either a simple name or a JSON Path to the field.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Human understandable message describing the problem.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Machine traceable error code indicating the type of problem.
        /// </summary>
        public string Code { get; set; }
    }
}
