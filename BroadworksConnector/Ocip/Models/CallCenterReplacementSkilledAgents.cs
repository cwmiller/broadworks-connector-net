using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReplacementSkilledAgents 
{
    [XmlElement(ElementName = "skillLevel", IsNullable = false)]
    public int SkillLevel { get; set; }
    [XmlElement(ElementName = "agents", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList Agents { get; set; }
 }
}
