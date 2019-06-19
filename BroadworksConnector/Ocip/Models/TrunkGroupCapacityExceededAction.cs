using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group capacity exceeded action.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupCapacityExceededAction
    {
        [XmlEnum(Name = "Forward")]
        Forward,
        [XmlEnum(Name = "Reroute")]
        Reroute,
    }
}
