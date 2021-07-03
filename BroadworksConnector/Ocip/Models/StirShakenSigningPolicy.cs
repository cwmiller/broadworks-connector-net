using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken Signing Policy.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenSigningPolicy
    {
        [XmlEnum(Name = "All Eligible Calls")]
        AllEligibleCalls,
        [XmlEnum(Name = "Eligible Inter-Network Calls")]
        EligibleInterNetworkCalls,
        [XmlEnum(Name = "Off")]
        Off,
    }
}
