namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error when a value goes below an allowed range
    /// </summary>
    public class MinInclusiveError : ValidationError
    {
        /// <summary>
        /// Name of the field that failed validation
        /// </summary>
        public string MemberName { get; private set; }

        /// <summary>
        /// Value that was out of range
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// Minimum value the field can be set to
        /// </summary>
        public int Min { get; private set; }

        public MinInclusiveError(object obj, string memberName, int value, int min)
        {
            Object = obj;
            MemberName = memberName;
            Value = value;
            Min = min;
            Message = $"Value of field {memberName} can't be less than {min}.";
        }
    }
}
