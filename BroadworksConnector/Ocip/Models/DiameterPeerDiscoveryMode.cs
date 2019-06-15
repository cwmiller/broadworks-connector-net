using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Diameter peer discovery mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DiameterPeerDiscoveryMode    {
            [XmlEnum(Name = "Legacy")]
        Legacy,
            [XmlEnum(Name = "Rfc6733Any")]
        Rfc6733Any,
            [XmlEnum(Name = "Rfc6733TLSOnly")]
        Rfc6733TLSOnly,
            [XmlEnum(Name = "Rfc6733TCPOnly")]
        Rfc6733TCPOnly,
     }
}
