using System.Collections.Generic;
using System.Linq;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a choice between fields is not selected.
    /// </summary>
    public class ChoiceNotSetException : ValidationException
    {
        public object Object { get; private set; }

        public IEnumerable<string> Options { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        public ChoiceNotSetException(object obj, IEnumerable<string> options)
            : base($"Choice not made between {string.Join(", ", options)} on {obj.GetType().Name}")
        {
            Object = obj;
            Options = options;
        }
    }
}
