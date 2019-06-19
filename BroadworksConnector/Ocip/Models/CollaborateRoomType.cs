using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for collaborate room type
    /// </summary>
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
