using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Types of owners/members in BroadWorks.
    /// MemberType contains the same list as UserType with "Normal" being split into "Place" and "User".
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MemberType
    {
        [XmlEnum(Name = "Place")]
        Place,
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "Auto Attendant")]
        AutoAttendant,
        [XmlEnum(Name = "BroadWorks Anywhere")]
        BroadWorksAnywhere,
        [XmlEnum(Name = "Call Center")]
        CallCenter,
        [XmlEnum(Name = "Collaborate Bridge")]
        CollaborateBridge,
        [XmlEnum(Name = "Contact Center Adapter")]
        ContactCenterAdapter,
        [XmlEnum(Name = "Contact Center Linked")]
        ContactCenterLinked,
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
        [XmlEnum(Name = "Voicemail Group")]
        VoicemailGroup,
        [XmlEnum(Name = "Voice Messaging")]
        VoiceMessaging,
        [XmlEnum(Name = "VoiceXML")]
        VoiceXML,
    }
}
