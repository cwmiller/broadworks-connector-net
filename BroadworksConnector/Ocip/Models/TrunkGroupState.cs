using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupState{
    [XmlEnum(Name = "Available")]
    Available,
    [XmlEnum(Name = "Unavailable")]
    Unavailable,
 }
}
