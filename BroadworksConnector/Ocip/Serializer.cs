using BroadWorksConnector.Ocip.Models.C;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip
{
    public class Serializer
    {
        public static XNamespace xsiNamespace = "http://www.w3.org/2001/XMLSchema-instance";
        public static XNamespace xsdNamespace = "http://www.w3.org/2001/XMLSchema";

        private string ModelNamespace { get; set; }

        public Serializer(string modelNamespace)
        {
            ModelNamespace = modelNamespace;
        }

        /// <summary>
        /// Serialize a BroadsoftDocument object
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public string Serialize(BroadsoftDocument document)
        {
            var rootElement = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
               SerializeRoot(document)
            );

            return rootElement.Declaration + Environment.NewLine + rootElement.ToString();
        }

        public BroadsoftDocument Deserialize(string xml)
        {
            var doc = XDocument.Parse(xml);

            var obj = DeserializeElement(doc.Root, typeof(BroadsoftDocument)) as BroadsoftDocument;

            return obj;
        }

        /// <summary>
        /// Serialize the root object for a request.
        /// This should always be BroadsoftDocument
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private XElement SerializeRoot(object obj)
        {
            var objType = obj.GetType();
            XNamespace ns = "";
            var elementName = objType.Name;

            // XmlRoot attribute will contain useful information such as namespace
            XmlRootAttribute xmlRootAttr = Attribute.GetCustomAttribute(objType, typeof(XmlRootAttribute)) as XmlRootAttribute;

            if (xmlRootAttr != null)
            {
                // Override defaults if attribute properties are set
                if (xmlRootAttr.Namespace != null)
                {
                    ns = xmlRootAttr.Namespace;
                }

                if (!string.IsNullOrEmpty(xmlRootAttr.ElementName))
                {
                    elementName = xmlRootAttr.ElementName;
                }
            }

            // Element contents is an object contianing all attributes and elements under this element
            return new XElement(ns + elementName,
                new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),
                GetElementContentsForInstance(objType, obj));
        }

        /// <summary>
        /// Returns all the child attributes and elements for a serialized object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        private List<object> GetElementContentsForInstance(Type type, object instance)
        {
            var contents = new List<object>();

            // Get all properties that are marked with XmlElementAttribute or XmlAttributeAttribute
            var properties = (from prop in type.GetProperties()
                              where Attribute.GetCustomAttribute(prop, typeof(XmlElementAttribute)) != null
                              || Attribute.GetCustomAttribute(prop, typeof(XmlAttributeAttribute)) != null
                              select prop);

            foreach (var property in properties)
            {
                if (IsPropertySpecified(property, type, instance))
                {
                    // Handle property if it's an XML Element
                    XmlElementAttribute elementAttr = Attribute.GetCustomAttribute(property, typeof(XmlElementAttribute)) as XmlElementAttribute;
                    if (elementAttr != null)
                    {
                        var propertyValue = property.GetValue(instance);

                        // If property value is enumerable, create an element for each one. Else just create an element for the value.
                        var asEnumerable = propertyValue as IEnumerable<object>;

                        if (asEnumerable != null)
                        {
                            foreach (var entry in asEnumerable)
                            {
                                contents.Add(SerializeElement(property, entry, elementAttr));
                            }
                        }
                        else
                        {
                            contents.Add(SerializeElement(property, propertyValue, elementAttr));
                        }
                    }

                    // Handle property if it's an XML Attribute
                    XmlAttributeAttribute attributeAttr = Attribute.GetCustomAttribute(property, typeof(XmlAttributeAttribute)) as XmlAttributeAttribute;
                    if (attributeAttr != null)
                    {
                        contents.Add(SerializeAttribute(property, property.GetValue(instance), attributeAttr));
                    }
                }
            }

            return contents;
        }

        /// <summary>
        /// Serializes a value into an XML element
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <param name="elementAttr"></param>
        /// <returns></returns>
        private XElement SerializeElement(PropertyInfo property, object value, XmlElementAttribute elementAttr)
        {
            // Get the type of the value. If it's null then use the type expressed by the property itself
            var valueType = value != null
                ? value.GetType()
                : property.PropertyType;

            // Element name should be in the attribute, else use the property name
            var elementName = !string.IsNullOrEmpty(elementAttr.ElementName)
                ? elementAttr.ElementName
                : property.Name;

            var isNillable = elementAttr.IsNullable == true;

            // Namespace defaults to blank unless it's specified in the attribute
            XNamespace ns = elementAttr.Namespace != null
                ? elementAttr.Namespace
                : "";

            // Primitive types, nulls, and strings should create an element with the value as a child.
            var isPrimitive = valueType.IsPrimitive
                || value == null
                || valueType.Equals(typeof(string));

            var isEnum = valueType.IsEnum;

            var elementAttributes = new List<object>();


            if (isEnum)
            {
                return new XElement(ns + elementName, elementAttributes, EnumForValue(valueType, value.ToString()));
            }
            else if (isPrimitive)
            {
                // Null values where the element is marked as Nillable gets an xsi:nil attribute included
                if (isNillable && value == null)
                {
                    elementAttributes.Add(new XAttribute(xsiNamespace + "nil", true));
                }

                return new XElement(ns + elementName, elementAttributes, value);
            }
            else
            {
                // If element extends an abstract class, include an xsi:type attribute
                if (ExtendsAbstract(valueType))
                {
                    elementAttributes.Add(new XAttribute(xsiNamespace + "type", valueType.Name));
                }

                return new XElement(ns + elementName, elementAttributes, GetElementContentsForInstance(valueType, value));
            }
        }

        /// <summary>
        /// Serializes an Enum value to a string
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private string EnumForValue(Type enumType, string value)
        {
            var xmlEnumAttr = enumType.GetField(value).GetCustomAttribute(typeof(XmlEnumAttribute)) as XmlEnumAttribute;

            if (xmlEnumAttr == null)
            {
                throw new ArgumentException("Enum doesn't have XmlEnum attribute", nameof(value));
            }

            return xmlEnumAttr.Name;
        }


        /// <summary>
        /// Serializes a value into an XML attribute
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <param name="attributeAttr"></param>
        /// <returns></returns>
        private XAttribute SerializeAttribute(PropertyInfo property, object value, XmlAttributeAttribute attributeAttr)
        {
            // Attribute name can be set via the attribute, else it'll use the property name
            var attributeName = !string.IsNullOrEmpty(attributeAttr.AttributeName)
                ? attributeAttr.AttributeName
                : property.Name;

            // namespace defaults to blank unless it's specified in the attribute
            XNamespace ns = attributeAttr.Namespace != null
                ? attributeAttr.Namespace
                : "";

            return new XAttribute(ns + attributeName, value);
        }

        /// <summary>
        /// Determines if a property was manually set.
        /// Only manually set properties get included in the XML
        /// </summary>
        /// <param name="property"></param>
        /// <param name="objectType"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        private bool IsPropertySpecified(PropertyInfo property, Type objectType, object instance)
        {
            // Instance will include a sibling property named PropertyNameSpecified that is set to true if the property was set.
            var specifiedProperty = objectType.GetProperty($"{property.Name}Specified", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            if (specifiedProperty == null)
            {
                throw new ArgumentException("Property does not have an associated Specified property.", nameof(property));
            }

            return (bool)specifiedProperty.GetValue(instance);
        }

        /// <summary>
        /// Determines if a class is abstract or extends one.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool ExtendsAbstract(Type type)
        {
            if (type.IsAbstract)
            {
                return true;
            }

            if (type.BaseType != null)
            {
                return ExtendsAbstract(type.BaseType);
            }

            return false;
        }

        /// <summary>
        /// Deserialize an element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="targetType"></param>
        /// <returns></returns>
        private object DeserializeElement(XElement element, Type targetType)
        {
            // If the element contains no elements, serialize its value
            if (!element.HasElements)
            {
                return DeserializeValue(element.Value, targetType);
            }

            // If the target type is abstract, then there should be an attribute on the XML element
            // telling us the concrete type
            if (targetType.IsAbstract)
            {
                var typeAttribute = element.Attribute(xsiNamespace + "type");

                if (typeAttribute != null)
                {
                    var typeName = $"{ModelNamespace}.{typeAttribute.Value.Replace("c:", "C.")}";

                    targetType = Type.GetType(typeName);
                }
            }

            if (targetType == null)
            {
                throw new ArgumentException("targetType cannot be null", nameof(targetType));
            }

            var obj = Activator.CreateInstance(targetType);

            // Iterate through properties in the object and set it
            var properties = targetType.GetProperties();

            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;
                var propertyIsList = propertyType.GetTypeInfo().IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(List<>);

                XmlElementAttribute elementAttr = Attribute.GetCustomAttribute(property, typeof(XmlElementAttribute)) as XmlElementAttribute;
                if (elementAttr != null)
                {
                    if (propertyIsList)
                    {
                        // Since the destination is a list, we need to get the type the list is composed of so we can construct them.
                        var individualType = propertyType.GetTypeInfo().GenericTypeArguments[0];

                        var childElements = element.Elements(elementAttr.ElementName);

                        if (childElements.Count() > 0)
                        {
                            var list = Activator.CreateInstance(propertyType) as IList;

                            foreach (var childElement in childElements)
                            {
                                list.Add(DeserializeElement(childElement, individualType));
                            }

                            property.SetValue(obj, list);
                        }
                    }
                    else
                    {
                        var childElement = element.Element(elementAttr.ElementName);
                        if (childElement != null)
                        {
                            property.SetValue(obj, DeserializeElement(childElement, propertyType));
                        }
                    }
                }

                XmlAttributeAttribute attributeAttr = Attribute.GetCustomAttribute(property, typeof(XmlAttributeAttribute)) as XmlAttributeAttribute;
                if (attributeAttr != null)
                {
                    var attribute = element.Attribute(attributeAttr.AttributeName);
                    if (attribute != null)
                    {
                        property.SetValue(obj, attribute.Value);
                    }
                }
            }

            return obj;
        }

        /// <summary>
        /// Deserialize a primitive value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <returns></returns>
        private object DeserializeValue(string value, Type targetType)
        {
            if (targetType.Equals(typeof(bool)))
            {
                return value == "true";
            }

            if (targetType.Equals(typeof(int)))
            {
                return int.Parse(value);
            }

            if (targetType.Equals(typeof(decimal)))
            {
                return decimal.Parse(value);
            }

            if (targetType.IsEnum)
            {
                return DeserializeEnum(value, targetType);
            }

            return value;
        }

        /// <summary>
        /// Deserialize a string to enum
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <returns></returns>
        private object DeserializeEnum(string value, Type targetType)
        {
            if (!targetType.IsEnum)
            {
                throw new ArgumentException("Type is not an Enum", nameof(targetType));
            }

            var enumValue = targetType.GetFields().Where(field =>
            {
                var enumAttr = Attribute.GetCustomAttribute(field, typeof(XmlEnumAttribute)) as XmlEnumAttribute;

                return (enumAttr?.Name == value);
            }).FirstOrDefault();

            if (enumValue == null)
            {
                throw new InvalidOperationException($"Value {value} has no corresponding enum value on {targetType}");
            }

            return Enum.Parse(targetType, enumValue.Name);
        }
    }
}
