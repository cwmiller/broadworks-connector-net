namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a value exceeds the allowed range.
    /// </summary>
    public class MaxInclusiveException : ValidationException
    {
        public string PropertyName { get; private set; }

        public int Value { get; private set; }

        public int Max { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <param name="max"></param>
        public MaxInclusiveException(string propertyName, int value, int max) : base($"Value of field {propertyName} can't be greater than {max}.")
        {
            PropertyName = propertyName;
            Value = value;
            Max = max;
        }
    }
}
