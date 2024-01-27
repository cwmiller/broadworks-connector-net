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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4336""}]")]
    public class ReplacementCommunicationBarringIncomingRuleList19sp1
    {

        protected List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> _rule = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1>();

        [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4336")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> Rule
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
