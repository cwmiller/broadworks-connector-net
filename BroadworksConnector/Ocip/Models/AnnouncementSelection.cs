using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Announcement Selection.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AnnouncementSelection
    {
        [XmlEnum(Name = "Default")]
        Default,
        [XmlEnum(Name = "Personal")]
        Personal,
    }
}
