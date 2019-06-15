using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unscreened Presentation Identity Policy Options
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum UnscreenedPresentationIdentityPolicy    {
            [XmlEnum(Name = "Profile Presentation Identity")]
        ProfilePresentationIdentity,
            [XmlEnum(Name = "Unscreened Presentation Identity")]
        UnscreenedPresentationIdentity,
            [XmlEnum(Name = "Unscreened Presentation Identity With Profile Domain")]
        UnscreenedPresentationIdentityWithProfileDomain,
     }
}
