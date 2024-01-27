using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Recording Service Play Resume Notification Type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RecordingPauseResumeNotificationType
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Beep")]
        Beep,
        [XmlEnum(Name = "Play Announcement")]
        PlayAnnouncement,
    }
}
