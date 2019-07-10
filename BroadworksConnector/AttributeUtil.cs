using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace BroadWorksConnector
{
    /// <summary>
    /// Utility for retrieving attributes for types
    /// Information is cached to improve performance of future requests.
    /// </summary>
    internal class AttributeUtil
    {
        private static Dictionary<string, List<Attribute>> _cache = new Dictionary<string, List<Attribute>>();

        /// <summary>
        /// Retrieve attribute
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="member"></param>
        /// <returns></returns>
        public static T Get<T>(MemberInfo member) where T : Attribute
        {
            var allAttributes = GetAll(member);
            var attrType = typeof(T);

            return allAttributes.Where(attr => attr.GetType() == attrType).FirstOrDefault() as T;
        }

        /// <summary>
        /// Retrieve all attributes on a member
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static IEnumerable<Attribute> GetAll(MemberInfo member)
        {
            // Cache key is in format ObjectFullName or ObjectFullName#Property
            var memberCacheKey = (member is TypeInfo memberInfo)
                ? memberInfo.FullName
                : $"{member.DeclaringType?.FullName}#{member.Name}"; 

            if (_cache.ContainsKey(memberCacheKey))
            {
                return _cache[memberCacheKey];
            }
            else
            {
                // Retrieves all attributes on the member and store them in a list
                var allAtrributes = Attribute.GetCustomAttributes(member).ToList();

                _cache.Add(memberCacheKey, allAtrributes);

                return allAtrributes;
            }
        }
    }
}
