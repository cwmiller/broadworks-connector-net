using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Maximum Call Time for Unanswered Calls
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallingLineIdentityForRedirectedCalls
    {
        [XmlEnum(Name = "Originating Identity")]
        OriginatingIdentity,
        [XmlEnum(Name = "Redirecting User Identity For External Redirections")]
        RedirectingUserIdentityForExternalRedirections,
        [XmlEnum(Name = "Redirecting User Identity For All Redirections")]
        RedirectingUserIdentityForAllRedirections,
    }
}
