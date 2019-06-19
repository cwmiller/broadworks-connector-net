using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Center Routing type for distributing calls within a call center.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterRoutingType
    {
        [XmlEnum(Name = "Priority Based")]
        PriorityBased,
        [XmlEnum(Name = "Skill Based")]
        SkillBased,
    }
}
