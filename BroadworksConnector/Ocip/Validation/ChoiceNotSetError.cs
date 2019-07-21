using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error happens when no member has been set in a choice group.
    /// </summary>
    public class ChoiceNotSetError : ValidationError
    {
        /// <summary>
        /// List of member names in the choice group
        /// </summary>
        public IEnumerable<string> Members { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="members"></param>
        public ChoiceNotSetError(object obj, IEnumerable<string> members)
        {
            Object = obj;
            Members = members;
            Message = $"Choice not made between {string.Join(", ", members)} on {obj.GetType().Name}";
        }
    }
}
