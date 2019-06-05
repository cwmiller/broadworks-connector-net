using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
