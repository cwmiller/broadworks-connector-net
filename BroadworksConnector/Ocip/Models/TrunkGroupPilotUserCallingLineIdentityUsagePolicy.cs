using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group Pilot User Calling Line Identity policy
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupPilotUserCallingLineIdentityUsagePolicy
    {
        [XmlEnum(Name = "All Originating Calls")]
        AllOriginatingCalls,
        [XmlEnum(Name = "Unscreened Originating Calls")]
        UnscreenedOriginatingCalls,
        [XmlEnum(Name = "No Calls")]
        NoCalls,
    }
}
