using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringOriginatingRuleList 
{
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingRule> _rule;

    [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingRule> Rule {
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
