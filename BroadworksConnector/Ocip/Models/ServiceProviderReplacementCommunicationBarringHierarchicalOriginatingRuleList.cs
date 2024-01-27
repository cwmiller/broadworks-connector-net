using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Service Provider Communication Barring Hierarchical Originating Rules that replaces a previously configured list. By convention, an element of this type
    /// may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4986""}]")]
    public class ServiceProviderReplacementCommunicationBarringHierarchicalOriginatingRuleList
    {

        protected List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> _rule = new List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule>();

        [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4986")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalOriginatingRule> Rule
        {
            get => _rule;
            set
            {
                RuleSpecified = true;
                _rule = value;
            }
        }

        [XmlIgnore]
        protected bool RuleSpecified { get; set; }

    }
}
