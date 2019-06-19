using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The type of Announcement, the possible values are "Group" for a group level
    /// announcement or "User" for a user level announcement.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AnnouncementRepositoryType
    {
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "User")]
        User,
    }
}
