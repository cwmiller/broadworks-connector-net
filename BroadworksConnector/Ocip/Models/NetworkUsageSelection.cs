using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NetworkUsageSelection{
    [XmlEnum(Name = "Force All Calls")]
    ForceAllCalls,
    [XmlEnum(Name = "Force All Except Extension and Location Calls")]
    ForceAllExceptExtensionandLocationCalls,
    [XmlEnum(Name = "Do Not Force Enterprise and Group Calls")]
    DoNotForceEnterpriseandGroupCalls,
 }
}
