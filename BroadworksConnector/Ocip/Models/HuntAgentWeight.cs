using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The weighted call distribution weight for an agent.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2471""}]")]
    public class HuntAgentWeight
    {

        private string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2471")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AgentUserId
        {
            get => _agentUserId;
            set
            {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }

        private int _weight;

        [XmlElement(ElementName = "weight", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2471")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
        public int Weight
        {
            get => _weight;
            set
            {
                WeightSpecified = true;
                _weight = value;
            }
        }

        [XmlIgnore]
        public bool WeightSpecified { get; set; }

    }
}
