namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a choice between fields is not selected.
    /// </summary>
    public class ChoiceNotSetException : ValidationException
    {
        public object Object { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        public ChoiceNotSetException(object obj) : base($"Choice not made on {obj.GetType().Name}")
        {
            Object = obj;
        }
    }
}
