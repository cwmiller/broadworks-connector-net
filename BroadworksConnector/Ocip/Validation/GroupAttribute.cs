using System;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Attribute for indicating what group a property belongs to.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class GroupAttribute : Attribute
    {
        public string Id { get; private set; }

        public GroupAttribute(string id)
        {
            Id = id;
        }
    }
}
