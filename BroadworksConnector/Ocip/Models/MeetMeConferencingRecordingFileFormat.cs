using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Conference recording file format.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MeetMeConferencingRecordingFileFormat    {
            [XmlEnum(Name = "WAV")]
        WAV,
            [XmlEnum(Name = "MP3")]
        MP3,
     }
}
