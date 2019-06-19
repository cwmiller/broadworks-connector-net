using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The media type of media data.
    /// WMA - Windows Media Audio file
    /// WAV - A WAV file
    /// 3GP - A 3GP file
    /// MOV - A MOV file using a H.263 or H.264 codec.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MediaFileType
    {
        [XmlEnum(Name = "WMA")]
        WMA,
        [XmlEnum(Name = "WAV")]
        WAV,
        [XmlEnum(Name = "3GP")]
        _3GP,
        [XmlEnum(Name = "MOV")]
        MOV,
    }
}
