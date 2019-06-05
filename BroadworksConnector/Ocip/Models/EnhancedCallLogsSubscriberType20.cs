using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnhancedCallLogsSubscriberType20
    {
        [XmlEnum(Name = "Auto Attendant")]
        AutoAttendant,
        [XmlEnum(Name = "BroadWorks Anywhere Portal")]
        BroadWorksAnywherePortal,
        [XmlEnum(Name = "Call Center")]
        CallCenter,
        [XmlEnum(Name = "Find-me/Follow-me")]
        FindmeFollowme,
        [XmlEnum(Name = "Flexible Seating Host")]
        FlexibleSeatingHost,
        [XmlEnum(Name = "Hunt Group")]
        HuntGroup,
        [XmlEnum(Name = "Route Point")]
        RoutePoint,
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "VoiceXML")]
        VoiceXML,
    }
}
