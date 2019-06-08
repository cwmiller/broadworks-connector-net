using BroadWorksConnector.Ocip.Models.C;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip
{
    [XmlRootAttribute(Namespace = "C")]
    public class BroadsoftDocument : OCIMessage
    {
        [XmlAttribute(AttributeName = "protocol")]
        public string Protocol { get; set; }
    }
}
