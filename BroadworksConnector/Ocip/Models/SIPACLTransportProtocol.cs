using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPACLTransportProtocol{
    [XmlEnum(Name = "UDP")]
    UDP,
    [XmlEnum(Name = "TCP")]
    TCP,
    [XmlEnum(Name = "All")]
    All,
 }
}
