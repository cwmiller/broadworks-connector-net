using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkMode{
    [XmlEnum(Name = "Pilot")]
    Pilot,
    [XmlEnum(Name = "Proxy")]
    Proxy,
    [XmlEnum(Name = "User")]
    User,
 }
}
