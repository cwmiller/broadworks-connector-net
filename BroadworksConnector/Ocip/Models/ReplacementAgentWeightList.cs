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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3076""}]")]
    public class ReplacementAgentWeightList
    {

        private List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> _agentWeight = new List<BroadWorksConnector.Ocip.Models.HuntAgentWeight>();

        [XmlElement(ElementName = "agentWeight", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3076")]
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
        public bool AgentWeightSpecified { get; set; }

    }
}
