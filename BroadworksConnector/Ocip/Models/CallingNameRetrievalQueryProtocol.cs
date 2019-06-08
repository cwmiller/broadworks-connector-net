using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallingNameRetrievalQueryProtocol{
    [XmlEnum(Name = "Sip")]
    Sip,
    [XmlEnum(Name = "Soap")]
    Soap,
 }
}
