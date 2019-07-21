namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error when a field must be a specific length
    /// </summary>
    public class LengthError : ValidationError
    {
        public string MemberName { get; private set; }

        public int Actual { get; private set; }

        public int Expected { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="memberName"></param>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        public LengthError(object obj, string memberName, int actual, int expected)
        {
            Object = obj;
            MemberName = memberName;
            Actual = actual;
            Expected = expected;
            Message = $"Length of field {memberName} must be {expected}.";
        }
    }
}
