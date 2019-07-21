namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error when a member's value exceeds the allowed length
    /// </summary>
    public class MaxLengthError : ValidationError
    {
        /// <summary>
        /// Name of the field with the error
        /// </summary>
        public string MemberName { get; private set; }

        /// <summary>
        /// Length of the invalid field 
        /// </summary>
        public int Actual { get; private set; }

        /// <summary>
        /// Max length allowed for the value
        /// </summary>
        public int Max { get; private set; }

        public MaxLengthError(object obj, string memberName, int actual, int max)
        {
            Object = obj;
            MemberName = memberName;
            Actual = actual;
            Max = max;
            Message = $"Length of field {memberName} can't be over {max}.";
        }
    }
}
