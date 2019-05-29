using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum AutomaticCallbackReleaseCause{
    Busy,
    Forbidden,
    GlobalFailure,
    RequestFailure,
    ServerFailure,
    TranslationFailure,
    TemporarilyUnavailable,
    UserNotFound,
    RequestTimeout,
 }
}
