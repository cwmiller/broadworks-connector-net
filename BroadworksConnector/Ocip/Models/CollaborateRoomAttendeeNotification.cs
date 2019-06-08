using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CollaborateRoomAttendeeNotification{
    [XmlEnum(Name = "Play Tone")]
    PlayTone,
    [XmlEnum(Name = "No Notification")]
    NoNotification,
 }
}
