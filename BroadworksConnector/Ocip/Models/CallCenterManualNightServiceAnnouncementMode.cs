using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center manual night service announcement mode.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterManualNightServiceAnnouncementMode
    {
        [XmlEnum(Name = "Normal Announcement")]
        NormalAnnouncement,
        [XmlEnum(Name = "Manual Announcement")]
        ManualAnnouncement,
    }
}
