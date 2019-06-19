namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when multiple fields are set in a choice group.
    /// </summary>
    public class InvalidChoiceException : ValidationException
    {
        public object Object { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        public InvalidChoiceException(object obj) : base($"Multiple options selected on {obj.GetType().Name}")
        {
            Object = obj;
        }
    }
}
