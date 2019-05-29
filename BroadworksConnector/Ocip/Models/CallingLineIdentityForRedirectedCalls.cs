using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallingLineIdentityForRedirectedCalls{
    OriginatingIdentity,
    RedirectingUserIdentityForExternalRedirections,
    RedirectingUserIdentityForAllRedirections,
 }
}
