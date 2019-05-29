using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementAgentWeightList 
{
    [XmlElement(ElementName = "agentWeight", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.HuntAgentWeight> AgentWeight { get; set; }
 }
}
