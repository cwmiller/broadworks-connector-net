using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Hunt group Uniform Call Distribution Policy Scope.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum HuntGroupUniformCallDistributionPolicyScope    {
            [XmlEnum(Name = "Agent")]
        Agent,
            [XmlEnum(Name = "Hunt Group")]
        HuntGroup,
     }
}
