using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Media types.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MediaType
    {
        [XmlEnum(Name = "Audio")]
        Audio,
        [XmlEnum(Name = "Video")]
        Video,
        [XmlEnum(Name = "Image")]
        Image,
    }
}
