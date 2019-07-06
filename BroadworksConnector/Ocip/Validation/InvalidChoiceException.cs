using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when multiple fields are set in a choice group.
    /// </summary>
    public class InvalidChoiceException : ValidationException
    {
        public object Object { get; private set; }

        public IEnumerable<string> Options { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        public InvalidChoiceException(object obj, IEnumerable<string> options) : base($"Multiple options selected between {string.Join(", ", options)} on {obj.GetType().Name}")
        {
            Object = obj;
            Options = options;
        }
    }
}
