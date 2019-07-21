namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error when a the length of a field's value is below the allowed amount
    /// </summary>
    public class MinLengthError : ValidationError
    {
        /// <summary>
        /// Name of field that failed validation
        /// </summary>
        public string MemberName { get; private set; }

        /// <summary>
        /// Length of field
        /// </summary>
        public int Actual { get; private set; }

        /// <summary>
        /// Minimum allowed length of field
        /// </summary>
        public int Min { get; private set; }

        public MinLengthError(object obj, string memberName, int actual, int min)
        {
            Object = obj;
            MemberName = memberName;
            Actual = actual;
            Min = min;
            Message = $"Length of field {memberName} must be at least {min}.";
        }
    }
}
