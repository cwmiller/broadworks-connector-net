using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DirectRouteOutgoingDTGPolicy
    {
        [XmlEnum(Name = "Direct Route DTG")]
        DirectRouteDTG,
        [XmlEnum(Name = "Trunk Group DTG")]
        TrunkGroupDTG,
    }
}
