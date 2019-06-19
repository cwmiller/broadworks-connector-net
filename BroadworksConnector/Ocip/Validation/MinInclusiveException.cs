namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a value is less than the allowed range.
    /// </summary>
    public class MinInclusiveException : ValidationException
    {
        public string PropertyName { get; private set; }

        public int Value { get; private set; }

        public int Min { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <param name="min"></param>
        public MinInclusiveException(string propertyName, int value, int min) : base($"Value of field {propertyName} can't be less than {min}.")
        {
            PropertyName = propertyName;
            Value = value;
            Min = min;
        }
    }
}
