using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CommunicationBarringOriginatingAction15sp2{
    [XmlEnum(Name = "Allow")]
    Allow,
    [XmlEnum(Name = "Block")]
    Block,
    [XmlEnum(Name = "Authorization Code")]
    AuthorizationCode,
    [XmlEnum(Name = "Treatment")]
    Treatment,
    [XmlEnum(Name = "Transfer")]
    Transfer,
 }
}
