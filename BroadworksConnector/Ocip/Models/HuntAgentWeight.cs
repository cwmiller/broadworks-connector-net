using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class HuntAgentWeight 
{
    private string _agentUserId;

    [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
    public string AgentUserId {
        get => _agentUserId;
        set {
            AgentUserIdSpecified = true;
            _agentUserId = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserIdSpecified { get; set; }
    private int _weight;

    [XmlElement(ElementName = "weight", IsNullable = false, Namespace = "")]
    public int Weight {
        get => _weight;
        set {
            WeightSpecified = true;
            _weight = value;
        }
    }

    [XmlIgnore]
    public bool WeightSpecified { get; set; }
}
}
