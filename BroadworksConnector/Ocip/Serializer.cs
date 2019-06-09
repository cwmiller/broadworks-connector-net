using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// Serializes/Deserializes between BroadsoftDocument instances and XML
    /// </summary>
    public class Serializer
    {
        private readonly XmlSerializer _xmlSerializer;

        /// <summary>
        /// Constructor
        /// </summary>
        public Serializer()
        {
            _xmlSerializer = new XmlSerializer(typeof(BroadsoftDocument), "C");
        }

        /// <summary>
        /// Serialize instance of BroadsoftDocument into XML
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public string Serialize(BroadsoftDocument document)
        {
            string xml;

            using (var requestStream = new MemoryStream())
            {
                var xmlSettings = new XmlWriterSettings()
                {
                    Encoding = new UTF8Encoding(false), // UTF8 without byte order mark
                    Indent = false
                };

                using (var textWriter = XmlWriter.Create(requestStream, xmlSettings))
                {
                    _xmlSerializer.Serialize(textWriter, document);

                    textWriter.Flush();
                    requestStream.Flush();

                    xml = Encoding.UTF8.GetString(requestStream.ToArray());
                }
            }

            return xml;
        }

        /// <summary>
        /// Deserialize XML into BroadsoftDocument instance
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public BroadsoftDocument Deserialize(string xml)
        {
            BroadsoftDocument document = null;

            using (var reader = new StringReader(xml))
            {
                document = _xmlSerializer.Deserialize(reader) as BroadsoftDocument;
            }

            return document;
        }
    }
}
