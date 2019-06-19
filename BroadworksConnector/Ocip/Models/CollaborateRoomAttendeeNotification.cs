using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the notification when attendees join or leave the collaborate room session.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CollaborateRoomAttendeeNotification
    {
        [XmlEnum(Name = "Play Tone")]
        PlayTone,
        [XmlEnum(Name = "No Notification")]
        NoNotification,
    }
}
