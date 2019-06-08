using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DiameterPeerMode{
    [XmlEnum(Name = "Active")]
    Active,
    [XmlEnum(Name = "Standby")]
    Standby,
 }
}
