using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Center Uniform Call Distribution Policy Scope.
    /// </summary>
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
