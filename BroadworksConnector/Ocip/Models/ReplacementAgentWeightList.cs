using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementAgentWeightList 
{
    private List<BroadworksConnector.Ocip.Models.HuntAgentWeight> _agentWeight;

    [XmlElement(ElementName = "agentWeight", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.HuntAgentWeight> AgentWeight {
        get => _agentWeight;
        set {
            AgentWeightSpecified = true;
            _agentWeight = value;
        }
    }

    [XmlIgnore]
    public bool AgentWeightSpecified { get; set; }
}
}
