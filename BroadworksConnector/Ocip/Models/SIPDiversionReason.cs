using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPDiversionReason{
    [XmlEnum(Name = "unknown")]
    Unknown,
    [XmlEnum(Name = "user-busy")]
    Userbusy,
    [XmlEnum(Name = "no-answer")]
    Noanswer,
    [XmlEnum(Name = "unavailable")]
    Unavailable,
    [XmlEnum(Name = "unconditional")]
    Unconditional,
    [XmlEnum(Name = "deflection")]
    Deflection,
    [XmlEnum(Name = "time-of-day")]
    Timeofday,
    [XmlEnum(Name = "do-not-disturb")]
    Donotdisturb,
    [XmlEnum(Name = "follow-me")]
    Followme,
    [XmlEnum(Name = "out-of-service")]
    Outofservice,
    [XmlEnum(Name = "away")]
    Away,
    [XmlEnum(Name = "transfer")]
    Transfer,
    [XmlEnum(Name = "voicemail")]
    Voicemail,
    [XmlEnum(Name = "hunt-group")]
    Huntgroup,
    [XmlEnum(Name = "call-center")]
    Callcenter,
    [XmlEnum(Name = "route-point")]
    Routepoint,
    [XmlEnum(Name = "BW-ImplicitID")]
    BWImplicitID,
    [XmlEnum(Name = "BW-ExplicitID")]
    BWExplicitID,
 }
}
