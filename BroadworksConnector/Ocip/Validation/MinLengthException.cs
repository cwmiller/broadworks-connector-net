namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a field is set to a value with a length shorter than allowed.
    /// </summary>
    public class MinLengthException : ValidationException
    {
        public string PropertyName { get; private set; }

        public int Actual { get; private set; }

        public int Min { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="actual"></param>
        /// <param name="min"></param>
        public MinLengthException(string propertyName, int actual, int min) : base($"Length of field {propertyName} must be at least {min}.")
        {
            PropertyName = propertyName;
            Actual = actual;
            Min = min;
        }
    }
}
