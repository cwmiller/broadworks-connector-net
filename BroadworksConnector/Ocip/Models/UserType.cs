using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Types of users in BroadWorks.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum UserType
    {
        [XmlEnum(Name = "Normal")]
        Normal,
        [XmlEnum(Name = "Auto Attendant")]
        AutoAttendant,
        [XmlEnum(Name = "BroadWorks Anywhere")]
        BroadWorksAnywhere,
        [XmlEnum(Name = "Call Center")]
        CallCenter,
        [XmlEnum(Name = "Collaborate Bridge")]
        CollaborateBridge,
        [XmlEnum(Name = "Find-me/Follow-me")]
        FindmeFollowme,
        [XmlEnum(Name = "Flexible Seating Host")]
        FlexibleSeatingHost,
        [XmlEnum(Name = "Group Paging")]
        GroupPaging,
        [XmlEnum(Name = "Hunt Group")]
        HuntGroup,
        [XmlEnum(Name = "Instant Group Call")]
        InstantGroupCall,
        [XmlEnum(Name = "Meet-Me Conferencing")]
        MeetMeConferencing,
        [XmlEnum(Name = "Music On Hold")]
        MusicOnHold,
        [XmlEnum(Name = "Route Point")]
        RoutePoint,
        [XmlEnum(Name = "Voice Messaging")]
        VoiceMessaging,
        [XmlEnum(Name = "VoiceXML")]
        VoiceXML,
    }
}
