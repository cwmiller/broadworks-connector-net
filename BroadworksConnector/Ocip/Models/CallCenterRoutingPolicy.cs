using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
