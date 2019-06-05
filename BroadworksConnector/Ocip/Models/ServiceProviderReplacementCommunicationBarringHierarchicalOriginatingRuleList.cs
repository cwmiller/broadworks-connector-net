using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderReplacementCommunicationBarringHierarchicalOriginatingRuleList 
{
    private List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> _rule;

    [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> Rule {
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
