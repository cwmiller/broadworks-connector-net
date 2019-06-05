using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RecordingPauseResumeNotificationType{
    [XmlEnum(Name = "None")]
    None,
    [XmlEnum(Name = "Beep")]
    Beep,
    [XmlEnum(Name = "Play Announcement")]
    PlayAnnouncement,
 }
}
