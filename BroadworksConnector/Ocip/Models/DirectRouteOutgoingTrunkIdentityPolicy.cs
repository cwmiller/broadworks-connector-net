using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Direct Route Outgoing Trunk Identity policy to access device.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DirectRouteOutgoingTrunkIdentityPolicy    {
            [XmlEnum(Name = "Direct Route Trunk Identity")]
        DirectRouteTrunkIdentity,
            [XmlEnum(Name = "Trunk Group Trunk Identity")]
        TrunkGroupTrunkIdentity,
     }
}
