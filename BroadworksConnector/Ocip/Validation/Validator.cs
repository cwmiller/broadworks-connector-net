using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
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
        /// <returns>A ValidationResult indicating if the object is valid or what the errors are.</returns>
        public static ValidationResult Validate(object instance)
        {
            return new ValidationResult(ValidateObject(instance));
        }

        /// <summary>
        /// Validate an object
        /// </summary>
        /// <param name="instance"></param>
        /// <returns>A list of all errors encountered.</returns>
        private static IEnumerable<ValidationError> ValidateObject(object instance)
        {
            var errors = new List<ValidationError>();

            errors.AddRange(ValidateGroups(instance));
            errors.AddRange(ValidateProperties(instance));

            return errors;
        }

        /// <summary>
        /// Determine if the given property was manually set on an object
        /// </summary>
        /// <param name="property"></param>
        /// <param name="instance"></param>
        public static bool IsPropertySpecified(PropertyInfo property, object instance)
        {
            // Skip properties marked as Ignored to serializer
            if (AttributeUtil.Get<XmlIgnoreAttribute>(property) != null)
            {
                return false;
            }

            var type = instance.GetType();
            var specifiedFieldName = $"{property.Name}Specified";
            var specifiedProperty = type.GetProperty(specifiedFieldName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

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
        /// <returns>A list of all errors encountered.</returns>
        private static IEnumerable<ValidationError> ValidateGroups(object instance)
        {
            var errors = new List<ValidationError>();
            var groups = GetGroups(instance);

            foreach (var group in groups)
            {
                errors.AddRange(group.Validate(instance));
            }

            return errors;
        }

        /// <summary>
        /// Retrieve Sequence and Choice groups on an object
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        private static IEnumerable<Group> GetGroups(object instance)
        {
            var groups = new List<Group>();
            var type = instance.GetType();

            while (type != null)
            {
                // Object should have a Groups attribute containing the group details as JSON
                var groupsAttr = AttributeUtil.Get<GroupsAttribute>(type);

                if (groupsAttr == null)
                {
                    throw new ArgumentException("No Groups attribute on object", nameof(instance));
                }

                if (groupsAttr != null)
                {
                    // Parse JSON
                    using (var ms = new MemoryStream(Encoding.ASCII.GetBytes(groupsAttr.Json)))
                    {
                        groups.AddRange(_serializer.ReadObject(ms) as List<Group>);
                    }
                }

                if ((type.BaseType != null) && (type.BaseType != typeof(Object)))
                {
                    type = type.BaseType;
                }
                else
                {
                    type = null;
                }
            }

            return groups;
        }

        /// <summary>
        /// Validate any child objects and restrictions on primitive types
        /// </summary>
        /// <param name="instance"></param>
        /// <returns>A list of all errors encountered.</returns>
        private static IEnumerable<ValidationError> ValidateProperties(object instance)
        {
            var errors = new List<ValidationError>();
            var type = instance.GetType();

            foreach (var prop in type.GetProperties())
            {
                if (IsPropertySpecified(prop, instance))
                {
                    var value = prop.GetValue(instance, null);

                    var isList = prop.PropertyType.GetInterfaces()
                            .Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IList<>));

                    if (isList)
                    {
                        foreach (var element in (IEnumerable)value)
                        {
                            if (IsValidatableObject(element))
                            {
                                errors.AddRange(ValidateObject(element));
                            }
                        }
                    }
                    else if (IsValidatableObject(value))
                    {
                        errors.AddRange(ValidateObject(value));
                    }
                    else
                    {
                        errors.AddRange(ValidatePropertyRestrictions(instance, prop, value));
                    }
                }
            }

            return errors;
        }

        /// <summary>
        /// Determines if a value is an object that should be ran through the validator
        /// </summary>
        /// <param name="value"></param>
        /// <returns>If an object should be ran through the Validate method.</returns>
        private static bool IsValidatableObject(object value)
        {
            if (value is object)
            {
                var type = value.GetType();

                return !type.IsPrimitive                                    // Ignore primitives
                    && !type.Equals(typeof(string))                         // Ignore strings
                    && !type.IsEnum                                         // Ignore enums
                    && AttributeUtil.Get<XmlIgnoreAttribute>(type) == null; // Ignore anything explicitly marked as ignore
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
        /// <returns>A list of all errors encountered.</returns>
        private static IEnumerable<ValidationError> ValidatePropertyRestrictions(object instance, PropertyInfo property, object value)
        {
            var errors = new List<ValidationError>();

            // Get all attributes on property
            var attributes = AttributeUtil.GetAll(property);

            foreach (var attribute in attributes)
            {
                switch (attribute)
                {
                    case LengthAttribute attr:
                        if (value != null && value.ToString().Length != attr.Length)
                        {
                            errors.Add(new LengthError(instance, property.Name, value.ToString().Length, attr.Length));
                        }
                        break;
                    case MinLengthAttribute attr:
                        if (value != null && value.ToString().Length < attr.Length)
                        {
                            errors.Add(new MinLengthError(instance, property.Name, value.ToString().Length, attr.Length));
                        }
                        break;
                    case MaxLengthAttribute attr:
                        if (value != null && value.ToString().Length > attr.Length)
                        {
                            errors.Add(new MaxLengthError(instance, property.Name, value.ToString().Length, attr.Length));
                        }
                        break;
                    case MinInclusiveAttribute attr:
                        if (value != null && (int)value < attr.Minimum)
                        {
                            errors.Add(new MinInclusiveError(instance, property.Name, (int)value, attr.Minimum));
                        }
                        break;
                    case MaxInclusiveAttribute attr:
                        if (value != null && (int)value > attr.Maximum)
                        {
                            errors.Add(new MaxInclusiveError(instance, property.Name, (int)value, attr.Maximum));
                        }
                        break;
                    case RegularExpressionAttribute attr:
                        if (value != null && !Regex.IsMatch(value.ToString(), attr.Pattern))
                        {
                            errors.Add(new PatternError(instance, property.Name, value.ToString(), attr.Pattern));
                        }

                        break;
                }
            }

            return errors;
        }
    }
}
