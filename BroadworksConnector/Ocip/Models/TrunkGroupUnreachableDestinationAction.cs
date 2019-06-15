using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group unreachable destination action.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupUnreachableDestinationAction    {
            [XmlEnum(Name = "Forward")]
        Forward,
            [XmlEnum(Name = "Reroute")]
        Reroute,
     }
}
