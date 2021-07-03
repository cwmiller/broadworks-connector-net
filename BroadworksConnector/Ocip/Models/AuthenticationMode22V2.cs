using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Device Authentication
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthenticationMode22V2
    {
        [XmlEnum(Name = "SIP Authentication")]
        SIPAuthentication,
        [XmlEnum(Name = "Certificate-based Authentication")]
        CertificatebasedAuthentication,
        [XmlEnum(Name = "Disabled")]
        Disabled,
    }
}
