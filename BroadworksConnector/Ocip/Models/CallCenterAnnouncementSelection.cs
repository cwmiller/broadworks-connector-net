using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Center Announcement Selection.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterAnnouncementSelection
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Custom")]
        Custom,
    }
}
