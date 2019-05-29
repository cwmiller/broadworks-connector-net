using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum InternalReleaseCause{
    Busy,
    Forbidden,
    RoutingFailure,
    GlobalFailure,
    RequestFailure,
    ServerFailure,
    TranslationFailure,
    TemporarilyUnavailable,
    UserNotFound,
    RequestTimeout,
    DialToneTimeout,
 }
}
