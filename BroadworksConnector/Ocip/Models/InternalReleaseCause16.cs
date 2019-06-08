using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum InternalReleaseCause16{
    [XmlEnum(Name = "Busy")]
    Busy,
    [XmlEnum(Name = "Forbidden")]
    Forbidden,
    [XmlEnum(Name = "Routing Failure")]
    RoutingFailure,
    [XmlEnum(Name = "Global Failure")]
    GlobalFailure,
    [XmlEnum(Name = "Request Failure")]
    RequestFailure,
    [XmlEnum(Name = "Server Failure")]
    ServerFailure,
    [XmlEnum(Name = "Translation Failure")]
    TranslationFailure,
    [XmlEnum(Name = "Temporarily Unavailable")]
    TemporarilyUnavailable,
    [XmlEnum(Name = "User Not Found")]
    UserNotFound,
    [XmlEnum(Name = "Request Timeout")]
    RequestTimeout,
    [XmlEnum(Name = "Dial Tone Timeout")]
    DialToneTimeout,
    [XmlEnum(Name = "Insufficient Credits")]
    InsufficientCredits,
 }
}
