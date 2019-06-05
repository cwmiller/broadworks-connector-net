using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CollaborateRoomType
    {
        [XmlEnum(Name = "Instant Room")]
        InstantRoom,
        [XmlEnum(Name = "My Room")]
        MyRoom,
        [XmlEnum(Name = "Project Room")]
        ProjectRoom,
    }
}
