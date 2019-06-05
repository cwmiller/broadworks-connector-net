using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum PhysicalLocationIndicator{
    [XmlEnum(Name = "CI")]
    CI,
    [XmlEnum(Name = "LAC-CI")]
    LACCI,
    [XmlEnum(Name = "PANI")]
    PANI,
    [XmlEnum(Name = "Disregard Zones")]
    DisregardZones,
 }
}
