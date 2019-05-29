using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class HuntAgentWeight 
{
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public string AgentUserId { get; set; }
    [XmlElement(ElementName = "weight", IsNullable = false)]
    public int Weight { get; set; }
 }
}
