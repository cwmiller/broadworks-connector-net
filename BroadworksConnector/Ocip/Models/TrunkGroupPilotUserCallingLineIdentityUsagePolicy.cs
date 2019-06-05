using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupPilotUserCallingLineIdentityUsagePolicy{
    [XmlEnum(Name = "All Originating Calls")]
    AllOriginatingCalls,
    [XmlEnum(Name = "Unscreened Originating Calls")]
    UnscreenedOriginatingCalls,
    [XmlEnum(Name = "No Calls")]
    NoCalls,
 }
}
