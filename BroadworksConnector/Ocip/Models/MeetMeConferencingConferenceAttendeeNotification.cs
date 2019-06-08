using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MeetMeConferencingConferenceAttendeeNotification{
    [XmlEnum(Name = "Play Tone")]
    PlayTone,
    [XmlEnum(Name = "Play Recorded Name")]
    PlayRecordedName,
    [XmlEnum(Name = "No Notification")]
    NoNotification,
 }
}
