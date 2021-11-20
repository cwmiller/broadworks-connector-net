using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models.C
{
    [XmlRoot(Namespace = "C")]
    public class BroadsoftDocument<T> : OCIMessage<T> where T : OCICommand
    {
        [XmlAttribute(AttributeName = "protocol")]
        public string Protocol { get; set; }

        [XmlIgnore]
        protected bool ProtocolSpecified { get => true; }
    }
}
