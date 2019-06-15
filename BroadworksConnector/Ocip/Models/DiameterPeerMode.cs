using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the mode of a Diameter Peer.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DiameterPeerMode    {
            [XmlEnum(Name = "Active")]
        Active,
            [XmlEnum(Name = "Standby")]
        Standby,
     }
}
