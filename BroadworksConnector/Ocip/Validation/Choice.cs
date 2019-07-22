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
        /// <returns>A list of all errors encountered.</returns>
        public override IEnumerable<ValidationError> Validate(object instance)
        {
            var errors = new List<ValidationError>();
            var type = instance.GetType();

            // Get all properties on object that are part of this group
            var requiredProperties =
                type.GetProperties()
                .Where(prop => AttributeUtil.Get<XmlIgnoreAttribute>(prop) == null)
                .Where(prop =>
                {
                    var groupAttribute = AttributeUtil.Get<GroupAttribute>(prop);

                    return groupAttribute != null && groupAttribute.Id == Id;
                });

            var options = new List<ChoiceOption>();

            options.AddRange(requiredProperties.Select(prop => new ChoiceFieldOption()
            {
                Name = prop.Name,
                Optional = AttributeUtil.Get<OptionalAttribute>(prop) != null,
                Set = IsFieldSet(prop, instance)
            }));

            if (Children != null)
            {
                // Find any Sequences that are children
                foreach (var child in Children)
                {
                    if (child is Sequence sequence)
                    {
                        var isSet = IsSequenceSet(sequence, instance);

                        // If any of the sequences have set fields, validate the Sequence to 
                        // enforce all required fields
                        if (isSet)
                        {
                            errors.AddRange(sequence.Validate(instance));
                        }

                        options.Add(new ChoiceSequenceOption()
                        {
                            Sequence = sequence,
                            Optional = false,
                            Set = isSet
                        });
                    }
                }
            }

            var setMembers = options.Where(opt => opt.Set);
            var nonOptionalMembers = options.Where(opt => !opt.Optional);

            if ((setMembers.Count() == 0) && (nonOptionalMembers.Count() != 0) && !Optional)
            {
                errors.Add(new ChoiceNotSetError(instance, OptionNames(options, type)));
            } else if (setMembers.Count() > 1)
            {
                errors.Add(new InvalidChoiceError(instance, OptionNames(options, type)));
            }

            return errors;
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
               .Where(prop => AttributeUtil.Get<XmlIgnoreAttribute>(prop) == null)
               .Where(prop =>
               {
                   var groupAttribute = AttributeUtil.Get<GroupAttribute>(prop);

                   return groupAttribute != null && groupAttribute.Id == sequence.Id;
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
                        .Where(prop => AttributeUtil.Get<XmlIgnoreAttribute>(prop) == null)
                        .Where(prop =>
                        {
                            var groupAttribute = AttributeUtil.Get<GroupAttribute>(prop);

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
