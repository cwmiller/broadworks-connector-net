using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MeetMeConferencingRecordingFileFormat{
    [XmlEnum(Name = "WAV")]
    WAV,
    [XmlEnum(Name = "MP3")]
    MP3,
 }
}
