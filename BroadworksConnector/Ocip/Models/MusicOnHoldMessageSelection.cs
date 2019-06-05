using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MusicOnHoldMessageSelection{
    [XmlEnum(Name = "System")]
    System,
    [XmlEnum(Name = "External")]
    External,
    [XmlEnum(Name = "Custom")]
    Custom,
 }
}
