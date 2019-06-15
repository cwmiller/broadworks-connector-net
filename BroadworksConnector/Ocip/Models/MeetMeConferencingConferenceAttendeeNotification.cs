using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the notification when attendees join or leave the conferecne.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MeetMeConferencingConferenceAttendeeNotification    {
            [XmlEnum(Name = "Play Tone")]
        PlayTone,
            [XmlEnum(Name = "Play Recorded Name")]
        PlayRecordedName,
            [XmlEnum(Name = "No Notification")]
        NoNotification,
     }
}
