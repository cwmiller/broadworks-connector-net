using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupCapacityExceededAction{
    [XmlEnum(Name = "Forward")]
    Forward,
    [XmlEnum(Name = "Reroute")]
    Reroute,
 }
}
