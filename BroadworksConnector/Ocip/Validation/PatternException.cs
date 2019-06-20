namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a value doesn't match the required pattern of a field.
    /// </summary>
    public class PatternException : ValidationException
    {
        public string PropertyName { get; private set; }

        public string Value { get; private set; }

        public string Pattern { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <param name="pattern"></param>
        public PatternException(string propertyName, string value, string pattern) : base($"Value of field {propertyName} must match pattern {pattern}.")
        {
            PropertyName = propertyName;
            Value = value;
            Pattern = pattern;
        }
    }
}
