using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ExtendedTransportProtocol{
    [XmlEnum(Name = "UDP")]
    UDP,
    [XmlEnum(Name = "TCP")]
    TCP,
    [XmlEnum(Name = "TLS")]
    TLS,
    [XmlEnum(Name = "Unspecified")]
    Unspecified,
 }
}
