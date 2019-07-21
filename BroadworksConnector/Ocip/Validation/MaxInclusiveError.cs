using System;
using System.Collections.Generic;
using System.Text;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error when a member's value is set above the allowed range
    /// </summary>
    class MaxInclusiveError : ValidationError
    {
        /// <summary>
        /// Name of the field with the error
        /// </summary>
        public string MemberName { get; private set; }

        /// <summary>
        /// Actual value that was set
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// The max allowed value
        /// </summary>
        public int Max { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="memberName"></param>
        /// <param name="value"></param>
        /// <param name="max"></param>
        public MaxInclusiveError(object obj, string memberName, int value, int max)
        {
            Object = obj;
            MemberName = memberName;
            Value = value;
            Max = max;
            Message = $"Value of field {memberName} can't be greater than {max}.";
        }
    }
}
