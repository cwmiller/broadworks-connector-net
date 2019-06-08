using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterRoutingType{
    [XmlEnum(Name = "Priority Based")]
    PriorityBased,
    [XmlEnum(Name = "Skill Based")]
    SkillBased,
 }
}
