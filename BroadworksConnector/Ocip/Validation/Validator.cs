using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Validates request objects
    /// Enforces sequence/choice and length/range requirements
    /// </summary>
    public static class Validator
    {
        private static DataContractJsonSerializer _serializer = new DataContractJsonSerializer(typeof(List<Group>), new List<Type>()
        {
            typeof(Sequence),
            typeof(Choice)
        });

        /// <summary>
        /// Validate an object
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static bool Validate(object instance)
        {
            ValidateGroups(instance);
            ValidateProperties(instance);

            return true;
        }

        /// <summary>
        /// Determine if the given property was manually set on an object
        /// </summary>
        /// <param name="property"></param>
        /// <param name="instance"></param>
        public static bool IsPropertySpecified(PropertyInfo property, object instance)
        {
            // Skip properties marked as Ignored to serializer
            if (Attribute.GetCustomAttribute(property, typeof(XmlIgnoreAttribute)) != null)
            {
                return false;
            }

            var type = instance.GetType();
            var specifiedFieldName = $"{property.Name}Specified";
            var specifiedProperty = type.GetProperty(specifiedFieldName);

            if (specifiedProperty == null)
            {
                throw new InvalidOperationException($"{specifiedFieldName} does not exist");
            }

            return (bool)specifiedProperty.GetValue(instance);
        }


        /// <summary>
        /// Retrieves all validation groups on an object and validates them
        /// </summary>
        /// <param name="instance"></param>
        private static void ValidateGroups(object instance)
        {
            var groups = GetGroups(instance);
            foreach (var group in groups)
            {
                group.Validate(instance);
            }
        }

        /// <summary>
        /// Retrieve Sequence and Choice groups on an object
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        private static IEnumerable<Group> GetGroups(object instance)
        {
            // Object should have a Groups attribute containing the group details as JSON
            var groupsAttr = (GroupsAttribute)Attribute.GetCustomAttribute(instance.GetType(), typeof(GroupsAttribute));

            if (groupsAttr == null)
            {
                throw new ArgumentException("No Groups attribute on object", nameof(instance));
            }

            var groups = new List<Group>();

            // Parse JSON
            using (var ms = new MemoryStream(Encoding.ASCII.GetBytes(groupsAttr.Json)))
            {
                groups = _serializer.ReadObject(ms) as List<Group>;
            }

            return groups;
        }

        /// <summary>
        /// Validate any child objects and restrictions on primitive types
        /// </summary>
        /// <param name="instance"></param>
        private static void ValidateProperties(object instance)
        {
            var type = instance.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (IsPropertySpecified(prop, instance))
                {
                    var value = prop.GetValue(instance, null);
                    var valueAsEnumerable = value as IEnumerable<object>;

                    if (valueAsEnumerable != null)
                    {
                        foreach (var element in valueAsEnumerable)
                        {
                            if (IsValidatableObject(element))
                            {
                                Validate(element);
                            }
                        }
                    }
                    else if (IsValidatableObject(value))
                    {
                        Validate(value);
                    }
                    else
                    {
                        ValidatePropertyRestrictions(prop, value);
                    }
                }
            }
        }

        /// <summary>
        /// Determines if a value is an object that should be ran through the validator
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool IsValidatableObject(object value)
        {
            if (value is object)
            {
                var type = value.GetType();

                return !type.IsPrimitive
                    && !type.Equals(typeof(string))
                    && !type.IsEnum
                    && Attribute.GetCustomAttribute(type, typeof(XmlIgnoreAttribute)) == null;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validates primitive types
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        private static void ValidatePropertyRestrictions(PropertyInfo property, object value)
        {
            // Get all attributes on property
            var attributes = Attribute.GetCustomAttributes(property);

            foreach (var attribute in attributes)
            {
                switch (attribute)
                {
                    case LengthAttribute attr:
                        if (value.ToString().Length != attr.Length)
                        {
                            throw new LengthException(property.Name, value.ToString().Length, attr.Length);
                        }
                        break;
                    case MinLengthAttribute attr:
                        if (value.ToString().Length < attr.Length)
                        {
                            throw new MinLengthException(property.Name, value.ToString().Length, attr.Length);
                        }
                        break;
                    case MaxLengthAttribute attr:
                        if (value.ToString().Length > attr.Length)
                        {
                            throw new MaxLengthException(property.Name, value.ToString().Length, attr.Length);
                        }
                        break;
                    case MinInclusiveAttribute attr:
                        if ((int)value < attr.Minimum)
                        {
                            throw new MinInclusiveException(property.Name, (int)value, attr.Minimum);
                        }
                        break;
                    case MaxInclusiveAttribute attr:
                        if ((int)value > attr.Maximum)
                        {
                            throw new MaxInclusiveException(property.Name, (int)value, attr.Maximum);
                        }
                        break;
                    case RegularExpressionAttribute attr:
                        if (!Regex.IsMatch(value.ToString(), attr.Pattern))
                        {
                            throw new PatternException(property.Name, value.ToString(), attr.Pattern);
                        }

                        break;
                }
            }

        }
    }
}
