using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DirectRouteOutgoingTrunkIdentityPolicy
    {
        [XmlEnum(Name = "Direct Route Trunk Identity")]
        DirectRouteTrunkIdentity,
        [XmlEnum(Name = "Trunk Group Trunk Identity")]
        TrunkGroupTrunkIdentity,
    }
}
