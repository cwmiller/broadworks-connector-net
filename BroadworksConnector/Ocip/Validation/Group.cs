using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Parent class for Sequence and Choice groups 
    /// </summary>
    [DataContract]
    [KnownType(typeof(Sequence))]
    [KnownType(typeof(Choice))]
    internal abstract class Group
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "children")]
        public IEnumerable<Group> Children { get; set; }

        public abstract IEnumerable<ValidationError> Validate(object instance);

        /// <summary>
        /// Constructor
        /// </summary>
        public Group()
        {
            Children = new List<Group>();
        }
    }
}
