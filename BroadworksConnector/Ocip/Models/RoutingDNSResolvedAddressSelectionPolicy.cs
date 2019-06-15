using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for choosing an address from the results of a DNS lookup.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RoutingDNSResolvedAddressSelectionPolicy    {
            [XmlEnum(Name = "Standard")]
        Standard,
            [XmlEnum(Name = "Load Balanced")]
        LoadBalanced,
            [XmlEnum(Name = "Stateful")]
        Stateful,
     }
}
