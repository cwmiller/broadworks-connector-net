using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// SIP ACL Network Transport Protocol.
    /// 
    /// The following values are only used in AS data mode and will fail in XS data mode:
    /// TLS
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SIPACLExtendedTransportProtocol
    {
        [XmlEnum(Name = "UDP")]
        UDP,
        [XmlEnum(Name = "TCP")]
        TCP,
        [XmlEnum(Name = "TLS")]
        TLS,
        [XmlEnum(Name = "All")]
        All,
    }
}
