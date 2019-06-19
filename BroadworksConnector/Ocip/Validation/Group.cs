using System;
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

        public abstract void Validate(object instance);

        /// <summary>
        /// Constructor
        /// </summary>
        public Group()
        {
            Children = new List<Group>();
        }

        /// <summary>
        /// Determine if the given property name was manually set
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="instance"></param>
        protected bool IsSpecified(string propertyName, object instance)
        {
            var type = instance.GetType();
            var specifiedFieldName = $"{propertyName}Specified";
            var property = type.GetProperty(specifiedFieldName);

            if (property == null)
            {
                throw new InvalidOperationException($"{specifiedFieldName} does not exist");
            }

            return (bool)property.GetValue(instance);
        }
    }
}
