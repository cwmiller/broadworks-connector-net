using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterSkillAgentList 
{
    [XmlElement(ElementName = "skillLevel", IsNullable = false)]
    public int SkillLevel { get; set; }
    [XmlElement(ElementName = "agent", IsNullable = false)]
    public List<string> Agent { get; set; }
 }
}
