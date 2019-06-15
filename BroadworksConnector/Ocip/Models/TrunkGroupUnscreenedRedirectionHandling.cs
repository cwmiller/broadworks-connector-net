using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Options to handle the trunk group INVITEs with an unscreened redirecting identity.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupUnscreenedRedirectionHandling    {
            [XmlEnum(Name = "Reject")]
        Reject,
            [XmlEnum(Name = "Ignore")]
        Ignore,
            [XmlEnum(Name = "Ignore If Unscreened Calls Disallowed")]
        IgnoreIfUnscreenedCallsDisallowed,
            [XmlEnum(Name = "Reject If Unscreened Calls Disallowed")]
        RejectIfUnscreenedCallsDisallowed,
     }
}
