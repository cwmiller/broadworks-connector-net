using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The media type of a voice message.
    /// WAV - A WAV file
    /// MP3 - an MP3 file
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingRecordingAudioFileFormat    {
            [XmlEnum(Name = "WAV")]
        WAV,
            [XmlEnum(Name = "MP3")]
        MP3,
     }
}
