using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Communication Barring Originating Rules that replaces a
    /// previously configured list. By convention, an element of this type
    /// may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:20009""}]")]
    public class ReplacementCommunicationBarringOriginatingRuleList
    {

        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingRule> _rule = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingRule>();

        [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:20009")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingRule> Rule
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
