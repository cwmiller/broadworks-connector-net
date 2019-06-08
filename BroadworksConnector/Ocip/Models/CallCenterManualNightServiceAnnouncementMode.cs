using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterManualNightServiceAnnouncementMode{
    [XmlEnum(Name = "Normal Announcement")]
    NormalAnnouncement,
    [XmlEnum(Name = "Manual Announcement")]
    ManualAnnouncement,
 }
}
