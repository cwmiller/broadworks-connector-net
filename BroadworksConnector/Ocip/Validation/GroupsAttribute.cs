using System;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Attribute containing a JSON object describing all the property groups in a request.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class GroupsAttribute : Attribute
    {
        public string Json { get; private set; }

        public GroupsAttribute(string json)
        {
            Json = json;
        }
    }
}
