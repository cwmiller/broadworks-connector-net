using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum TrunkGroupUnscreenedRedirectionHandling{
    Reject,
    Ignore,
    IgnoreIfUnscreenedCallsDisallowed,
    RejectIfUnscreenedCallsDisallowed,
 }
}
