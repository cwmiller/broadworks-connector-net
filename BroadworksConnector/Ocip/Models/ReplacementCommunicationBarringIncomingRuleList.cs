using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringIncomingRuleList 
{
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule> _rule;

    [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule> Rule {
        get => _rule;
        set {
            RuleSpecified = true;
            _rule = value;
        }
    }

    [XmlIgnore]
    public bool RuleSpecified { get; set; }
}
}
