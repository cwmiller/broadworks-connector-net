using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center routing policy.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterRoutingPolicy
    {
        [XmlEnum(Name = "Longest Wait Time")]
        LongestWaitTime,
        [XmlEnum(Name = "Priority")]
        Priority,
    }
}
