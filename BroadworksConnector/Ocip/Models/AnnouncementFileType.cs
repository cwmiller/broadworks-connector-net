using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AnnouncementFileType
    {
        [XmlEnum(Name = "Audio")]
        Audio,
        [XmlEnum(Name = "Video")]
        Video,
    }
}
