using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterAnnouncementSelection{
    [XmlEnum(Name = "System")]
    System,
    [XmlEnum(Name = "Custom")]
    Custom,
 }
}
