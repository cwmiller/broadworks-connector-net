namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a field is set to a value shorter or longer than the expected length.
    /// </summary>
    public class LengthException : ValidationException
    {
        public string PropertyName { get; private set; }

        public int Actual { get; private set; }

        public int Expected { get; private set; }

        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        public LengthException(string propertyName, int actual, int expected) : base($"Length of field {propertyName} must be {expected}.")
        {
            PropertyName = propertyName;
            Actual = actual;
            Expected = expected;
        }
    }
}
