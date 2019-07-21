namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error when a field's value does not match a regular expression
    /// </summary>
    public class PatternError : ValidationError
    {
        /// <summary>
        /// Field name that failed validation
        /// </summary>
        public string MemberName { get; private set; }

        /// <summary>
        /// Value of the invalid field
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Regex pattern the field should match
        /// </summary>
        public string Pattern { get; private set; }

        public PatternError(object obj, string memberName, string value, string pattern)
        {
            Object = obj;
            MemberName = memberName;
            Value = value;
            Pattern = pattern;
            Message = $"Value of field {memberName} must match pattern {pattern}.";
        }
    }
}
