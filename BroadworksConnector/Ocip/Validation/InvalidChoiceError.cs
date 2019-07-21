using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error for when multiple members have been set in a choice group
    /// </summary>
    public class InvalidChoiceError : ValidationError
    {
        /// <summary>
        /// Names of all members in the choice group
        /// </summary>
        public IEnumerable<string> Members { get; private set; }

        public InvalidChoiceError(object obj, IEnumerable<string> members)
        {
            Object = obj;
            Members = members;
            Message = $"Multiple options selected between {string.Join(", ", members)} on {obj.GetType().Name}";
        }
    }
}
