using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of agent userIds and hunt agent weights that replaces the previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4180""}]")]
    public class ReplacementAgentWeightList
    {

        protected List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> _agentWeight = new List<BroadWorksConnector.Ocip.Models.HuntAgentWeight>();

        [XmlElement(ElementName = "agentWeight", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4180")]
        public List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> AgentWeight
        {
            get => _agentWeight;
            set
            {
                AgentWeightSpecified = true;
                _agentWeight = value;
            }
        }

        [XmlIgnore]
        protected bool AgentWeightSpecified { get; set; }

    }
}
