using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum HoldAnnouncementMethodMode{
    [XmlEnum(Name = "Inactive")]
    Inactive,
    [XmlEnum(Name = "Bandwidth Attributes")]
    BandwidthAttributes,
 }
}
