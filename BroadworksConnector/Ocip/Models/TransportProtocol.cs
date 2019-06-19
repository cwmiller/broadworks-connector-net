using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Network Transport Protocol.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TransportProtocol
    {
        [XmlEnum(Name = "UDP")]
        UDP,
        [XmlEnum(Name = "TCP")]
        TCP,
        [XmlEnum(Name = "Unspecified")]
        Unspecified,
    }
}
