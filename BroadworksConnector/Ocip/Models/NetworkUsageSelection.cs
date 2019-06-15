using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Network Usage types.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum NetworkUsageSelection    {
            [XmlEnum(Name = "Force All Calls")]
        ForceAllCalls,
            [XmlEnum(Name = "Force All Except Extension and Location Calls")]
        ForceAllExceptExtensionandLocationCalls,
            [XmlEnum(Name = "Do Not Force Enterprise and Group Calls")]
        DoNotForceEnterpriseandGroupCalls,
     }
}
