using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The media type of media data.
    /// WMA - Windows Media Audio file
    /// WAV - A WAV file
    /// MP3 - An MP3 file
    /// This data type is only used in XS mode as MP3 is only supported in XS data mode.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AudioMediaFileType
    {
        [XmlEnum(Name = "WMA")]
        WMA,
        [XmlEnum(Name = "WAV")]
        WAV,
        [XmlEnum(Name = "MP3")]
        MP3,
    }
}
