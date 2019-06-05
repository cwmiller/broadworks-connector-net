using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceType{
    [XmlEnum(Name = "Auto Attendant")]
    AutoAttendant,
    [XmlEnum(Name = "Auto Attendant - Standard")]
    AutoAttendantStandard,
    [XmlEnum(Name = "BroadWorks Anywhere Portal")]
    BroadWorksAnywherePortal,
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
    [XmlEnum(Name = "Instant Conference Bridge")]
    InstantConferenceBridge,
    [XmlEnum(Name = "Meet-Me Conference Bridge")]
    MeetMeConferenceBridge,
    [XmlEnum(Name = "Route Point")]
    RoutePoint,
    [XmlEnum(Name = "VoiceXML")]
    VoiceXML,
 }
}
