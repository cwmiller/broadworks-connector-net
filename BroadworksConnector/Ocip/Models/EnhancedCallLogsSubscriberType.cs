using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Subscriber type
    /// Replaced by EnhancedCallLogsSubscriberType19sp1.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnhancedCallLogsSubscriberType
    {
        [XmlEnum(Name = "Auto Attendant")]
        AutoAttendant,
        [XmlEnum(Name = "BroadWorks Anywhere Portal")]
        BroadWorksAnywherePortal,
        [XmlEnum(Name = "Call Center")]
        CallCenter,
        [XmlEnum(Name = "Hunt Group")]
        HuntGroup,
        [XmlEnum(Name = "Route Point")]
        RoutePoint,
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "Find-me/Follow-me")]
        FindmeFollowme,
    }
}
