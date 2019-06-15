using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Service Provider Communication Barring Hierarchical Redirecting Rules that replaces a previously configured list. By convention, an element of this type
    /// may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderReplacementCommunicationBarringHierarchicalRedirectingRuleList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> _rule;

        [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> Rule {
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
