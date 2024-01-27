using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Communication Barring Incoming Rules that replaces a
    /// previously configured list. By convention, an element of this type
    /// may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:50305""}]")]
    public class ReplacementCommunicationBarringIncomingRuleList
    {

        protected List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule> _rule = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule>();

        [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:50305")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule> Rule
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
