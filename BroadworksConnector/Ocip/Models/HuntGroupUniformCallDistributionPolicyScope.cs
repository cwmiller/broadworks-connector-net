using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum HuntGroupUniformCallDistributionPolicyScope{
    [XmlEnum(Name = "Agent")]
    Agent,
    [XmlEnum(Name = "Hunt Group")]
    HuntGroup,
 }
}
