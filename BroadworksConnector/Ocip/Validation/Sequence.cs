﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// A sequence is a group of fields that must all be completed unless marked as Optional.
    /// </summary>
    [DataContract]
    internal class Sequence : Group
    {
        /// <summary>
        /// Validate sequence group
        /// </summary>
        /// <param name="instance"></param>
        public override void Validate(object instance)
        {
            var type = instance.GetType();

            // Get all properties on object that are part of this group and required
            var requiredProperties =
                type.GetProperties()
                .Where(prop => Attribute.GetCustomAttribute(prop, typeof(OptionalAttribute)) == null)
                .Where(prop => Attribute.GetCustomAttribute(prop, typeof(XmlIgnoreAttribute)) == null)
                .Where(prop =>
                {
                    var groupAttribute = Attribute.GetCustomAttribute(prop, typeof(GroupAttribute)) as GroupAttribute;
                    return groupAttribute != null && groupAttribute.Id == Id;
                });

            // Check if required properties are set
            foreach (var prop in requiredProperties)
            {
                var set = false;

                if (IsSpecified(prop.Name, instance))
                {

                    var value = prop.GetValue(instance, null);
                    var valueAsEnumerable = value as IEnumerable<object>;

                    if (valueAsEnumerable != null)
                    {
                        // Enumerables must have at least one entry
                        set = valueAsEnumerable.Count() > 0;
                    }
                    else
                    {
                        // Other values must not be null
                        set = value != null;
                    }
                }

                if (!set)
                {
                    throw new FieldNotSetException(instance, prop.Name);
                }
            }

            // Validate any child groups
            if (Children != null)
            {
                foreach (var child in Children)
                {
                    child.Validate(instance);
                }
            }
        }
    }
}