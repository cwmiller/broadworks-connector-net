using System;
using System.Runtime.Serialization;
using System.Linq;
using System.Xml.Serialization;
using System.Reflection;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Choice groups require only one property set in a group
    /// </summary>
    [DataContract]
    internal class Choice : Group
    {
        [DataMember(Name = "optional")]
        public bool Optional { get; set; }

        /// <summary>
        /// Validate choice group
        /// </summary>
        /// <param name="instance"></param>
        public override void Validate(object instance)
        {
            var type = instance.GetType();

            // Get all properties on object that are part of this group
            var requiredProperties =
                type.GetProperties()
                .Where(prop => Attribute.GetCustomAttribute(prop, typeof(XmlIgnoreAttribute)) == null)
                .Where(prop =>
                {
                    var groupAttribute = Attribute.GetCustomAttribute(prop, typeof(GroupAttribute)) as GroupAttribute;
                    return groupAttribute != null && groupAttribute.Id == Id;
                });

            var options = new List<ChoiceOption>();

            options.AddRange(requiredProperties.Select(prop => new ChoiceFieldOption()
            {
                Name = prop.Name,
                Optional = Attribute.GetCustomAttribute(prop, typeof(OptionalAttribute)) != null,
                Set = IsFieldSet(prop, instance)
            }));

            if (Children != null)
            {
                options.AddRange(Children
                    .Where(child => child is Sequence)
                    .Select(child => new ChoiceSequenceOption()
                    {
                        Sequence = child as Sequence,
                        Optional = false,
                        Set = IsSequenceSet(child as Sequence, instance)
                    }));
            }

            var setMembers = options.Where(opt => opt.Set);
            var nonOptionalMembers = options.Where(opt => !opt.Optional);

            if ((setMembers.Count() == 0) && (nonOptionalMembers.Count() != 0) && !Optional)
            {
                throw new ChoiceNotSetException(instance, OptionNames(options, type));
            }

            if (setMembers.Count() > 1)
            {
                throw new InvalidChoiceException(instance, OptionNames(options, type));
            }
        }

        /// <summary>
        /// Determine if a field is set to a value
        /// </summary>
        /// <param name="property"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        private bool IsFieldSet(PropertyInfo property, object instance)
        {
            var set = false;

            if (Validator.IsPropertySpecified(property, instance))
            {
                var value = property.GetValue(instance, null);
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

            return set;
        }

        /// <summary>
        /// Determine if a field in sequence has been set
        /// </summary>
        /// <param name="sequence"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        private bool IsSequenceSet(Sequence sequence, object instance)
        {
            var set = false;

            // Get properties that are part of sequence
            var requiredProperties =
               instance.GetType().GetProperties()
               .Where(prop => Attribute.GetCustomAttribute(prop, typeof(XmlIgnoreAttribute)) == null)
               .Where(prop =>
               {
                   var groupAttribute = Attribute.GetCustomAttribute(prop, typeof(GroupAttribute)) as GroupAttribute;
                   return groupAttribute != null && groupAttribute.Id == Id;
               });

            foreach (var property in requiredProperties)
            {
                if (IsFieldSet(property, instance))
                {
                    set = true;
                }
            }

            return set;
        }

        /// <summary>
        /// Retrieves all the properties/groups that are part of the group
        /// </summary>
        /// <param name="options"></param>
        /// <param name="instanceType"></param>
        /// <returns></returns>
        private IEnumerable<string> OptionNames(IEnumerable<ChoiceOption> options, Type instanceType)
        {
            return options.Select(opt =>
            {
                if (opt is ChoiceFieldOption fieldOpt)
                {
                    return fieldOpt.Name;
                } else if (opt is ChoiceSequenceOption sequenceOpt)
                {
                    var seqProperties =
                        instanceType.GetProperties()
                        .Where(prop => Attribute.GetCustomAttribute(prop, typeof(XmlIgnoreAttribute)) == null)
                        .Where(prop =>
                        {
                            var groupAttribute = Attribute.GetCustomAttribute(prop, typeof(GroupAttribute)) as GroupAttribute;
                            return groupAttribute != null && groupAttribute.Id == sequenceOpt.Sequence.Id;
                        })
                        .Select(prop => prop.Name);

                    return $"[{string.Join(", ", seqProperties)}]";
                }
                else
                {
                    throw new InvalidOperationException("Unknown choice option");
                }
            });
        }
    }
}
