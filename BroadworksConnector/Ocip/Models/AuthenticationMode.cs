using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for SIP Device Authentication.
    /// Deprecated by AuthenticationMode22.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthenticationMode
    {
        [XmlEnum(Name = "Enabled")]
        Enabled,
        [XmlEnum(Name = "Disabled")]
        Disabled,
        [XmlEnum(Name = "Enabled With Web Portal Credentials")]
        EnabledWithWebPortalCredentials,
    }
}
