using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Announcement types - audio or video
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AnnouncementFileType    {
            [XmlEnum(Name = "Audio")]
        Audio,
            [XmlEnum(Name = "Video")]
        Video,
     }
}
