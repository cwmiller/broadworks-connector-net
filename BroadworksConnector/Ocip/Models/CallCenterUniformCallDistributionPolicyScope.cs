using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterUniformCallDistributionPolicyScope
    {
        [XmlEnum(Name = "Agent")]
        Agent,
        [XmlEnum(Name = "Call Center")]
        CallCenter,
    }
}
