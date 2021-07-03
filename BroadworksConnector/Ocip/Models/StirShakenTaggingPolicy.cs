using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken Tagging Policy.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenTaggingPolicy
    {
        [XmlEnum(Name = "All Eligible Calls")]
        AllEligibleCalls,
        [XmlEnum(Name = "Eligible Intra-Network Calls")]
        EligibleIntraNetworkCalls,
        [XmlEnum(Name = "Off")]
        Off,
    }
}
