using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group call forwarding always action.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupCallForwardingAlwaysAction    {
            [XmlEnum(Name = "Forward")]
        Forward,
            [XmlEnum(Name = "Reroute")]
        Reroute,
     }
}
