using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Direct Route Outgoing DTG policy to access devices.
    /// </summary>
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
