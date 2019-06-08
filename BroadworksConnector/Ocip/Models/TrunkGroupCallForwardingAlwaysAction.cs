using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupCallForwardingAlwaysAction{
    [XmlEnum(Name = "Forward")]
    Forward,
    [XmlEnum(Name = "Reroute")]
    Reroute,
 }
}
