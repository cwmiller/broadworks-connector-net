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
        public string Serialize<T>(BroadsoftDocument<T> document) where T : OCICommand
        {
            var rootElement = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
               SerializeRoot(document)
            );

            return rootElement.Declaration + Environment.NewLine + rootElement.ToString();
        }

        /// <summary>
        /// Deserialize a response to a BroadsoftDocument object
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public BroadsoftDocument<T> Deserialize<T>(string xml) where T : OCICommand
        {
            var document = XDocument.Parse(xml);

            return DeserializeElement(document.Root, typeof(BroadsoftDocument<T>)) as BroadsoftDocument<T>;
        }

        /// <summary>
        /// Deserialize a response to a BroadsoftDocument object
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public BroadsoftDocument<OCICommand> Deserialize(string xml)
        {
            var document = XDocument.Parse(xml);

            return DeserializeElement(document.Root, typeof(BroadsoftDocument<OCICommand>)) as BroadsoftDocument<OCICommand>;
        }

        /// <summary>
        /// Serialize the root object for a request.
        /// This should always be BroadsoftDocument
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        private XElement SerializeRoot<T>(BroadsoftDocument<T> document) where T : OCICommand
        {
            var documentType = typeof(BroadsoftDocument<T>);

            var ns = XNamespace.None;

            // By default, element name will by the class name
            var elementName = "BroadsoftDocument";

            // XmlRoot attribute will contain useful information such as namespace
            var xmlRootAttr = AttributeUtil.Get<XmlRootAttribute>(documentType);

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
                GetElementContentsForInstance(documentType, document));
        }

        /// <summary>
        /// Returns all the child attributes and elements in serialized form for an object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        private List<XObject> GetElementContentsForInstance(Type type, object instance)
        {
            var contents = new List<XObject>();

            // Get all properties that are marked with XmlElementAttribute or XmlAttributeAttribute
            var properties = type.GetProperties()
                .Where(prop => AttributeUtil.GetAll(prop).Any(attr => attr is XmlElementAttribute || attr is XmlAttributeAttribute));

            foreach (var property in properties)
            {
                if (IsPropertySpecified(property, type, instance))
                {
                    var elementAttr = AttributeUtil.Get<XmlElementAttribute>(property);
                    var attributeAttr = AttributeUtil.Get<XmlAttributeAttribute>(property);

                    // Handle property if it's an XML Element
                    if (elementAttr != null)
                    {
                        var propertyValue = property.GetValue(instance);

                        // If property value is a list, create an element for each entry. Else just create an element for the value.
                        var isList = property.PropertyType.GetInterfaces()
                            .Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IList<>));

                        if (isList)
                        {
                            foreach (var entry in (IEnumerable)propertyValue)
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
                    else if (attributeAttr != null)
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
            var ns = elementAttr.Namespace ?? XNamespace.None;

            // Primitive types, nulls, and strings should create an element with the value as a child.
            var isPrimitive = valueType.IsPrimitive
                || value == null
                || valueType.Equals(typeof(string));

            var isEnum = valueType.IsEnum;

            var elementAttributes = new List<XAttribute>();

            if (isEnum)
            {
                return new XElement(ns + elementName, elementAttributes, EnumForValue(valueType, value.ToString()));
            }
            else
            {
                // If element extends an abstract class, include an xsi:type attribute
                if (!valueType.IsPrimitive && ExtendsAbstract(valueType))
                {
                    // If the field was set to NULL, use any type that inherits the abstract class
                    // Else use the type of the value
                    var xsiTypeToUse = (value == null)
                        ? valueType.Assembly.GetTypes().Where(type => type.IsSubclassOf(valueType)).OrderBy(t => t.Name).FirstOrDefault().Name
                        : valueType.Name;

                    elementAttributes.Add(new XAttribute(xsiNamespace + "type", xsiTypeToUse));
                }

                if (isPrimitive)
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
                    return new XElement(ns + elementName, elementAttributes, GetElementContentsForInstance(valueType, value));
                }
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
            var xmlEnumAttr = AttributeUtil.Get<XmlEnumAttribute>(enumType.GetField(value));

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
            var ns = attributeAttr.Namespace ?? XNamespace.None;

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
            // Serialize to primitive value if primitive or enum
            if (IsValueType(targetType))
            {
                return DeserializeValueType(element.Value, targetType);
            }

            // If the target type is abstract, then there should be an attribute on the XML element
            // telling us the concrete type
            if (targetType.IsAbstract)
            {
                var typeAttribute = element.Attribute(xsiNamespace + "type");

                if (typeAttribute != null)
                {
                    targetType = Type.GetType($"{ModelNamespace}.{typeAttribute.Value.Replace("c:", "C.")}");
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

                var elementAttr = AttributeUtil.Get<XmlElementAttribute>(property);
                var attributeAttr = AttributeUtil.Get<XmlAttributeAttribute>(property);

                // Handle when property is for an XML element
                if (elementAttr != null)
                {
                    if (propertyIsList)
                    {
                        // Since the destination is a list, we need to get the type the list is composed of so we can construct them.
                        var individualType = propertyType.GetTypeInfo().GenericTypeArguments[0];

                        // Get elements from the XML for the property
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
                // Handle when property is for an XML attribute
                else if (attributeAttr != null)
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
        /// Deserialize a string for a value type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <returns></returns>
        private object DeserializeValueType(string value, Type targetType)
        {
            if (!IsValueType(targetType))
            {
                throw new ArgumentException($"Type {targetType.Name} is not a value type", nameof(targetType));
            }

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
        /// Returns if an object type is a value type, which includes the primitive types and enums
        /// </summary>
        /// <param name="targetType"></param>
        /// <returns></returns>
        private bool IsValueType(Type targetType)
        {
            return targetType.Equals(typeof(bool))
                || targetType.Equals(typeof(int))
                || targetType.Equals(typeof(decimal))
                || targetType.Equals(typeof(float))
                || targetType.Equals(typeof(string))
                || targetType.IsEnum;
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
                var enumAttr = AttributeUtil.Get<XmlEnumAttribute>(field);

                return enumAttr?.Name == value;
            }).FirstOrDefault();

            if (enumValue == null)
            {
                throw new InvalidOperationException($"Value {value} has no corresponding enum value on {targetType}");
            }

            return Enum.Parse(targetType, enumValue.Name);
        }
    }
}
