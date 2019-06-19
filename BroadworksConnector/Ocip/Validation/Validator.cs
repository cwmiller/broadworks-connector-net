using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Validates request objects
    /// Enforces sequence/choice requirements
    /// TODO: length/range requirements
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
        /// Validate any child objects
        /// TODO: length/range requirements on values
        /// </summary>
        /// <param name="instance"></param>
        private static void ValidateProperties(object instance)
        {
            var type = instance.GetType();
            foreach (var prop in type.GetProperties())
            {
                var value = prop.GetValue(instance, null);
                var valueAsEnumerable = value as IEnumerable<object>;

                if (valueAsEnumerable != null)
                {
                    foreach (var element in valueAsEnumerable)
                    {
                        if (ShouldValidate(element))
                        {
                            Validate(element);
                        }
                    }
                }
                else if (ShouldValidate(value))
                {
                    Validate(value);
                }
                else
                {
                    // ValidatePropertyRestrictions(prop, value);
                }
            }
        }

        /// <summary>
        /// Determines if a value is an object that should be ran through the validator
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool ShouldValidate(object value)
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
        /// TODO
        /// </summary>
        private static void ValidatePropertyRestrictions()
        {

        }
    }
}
