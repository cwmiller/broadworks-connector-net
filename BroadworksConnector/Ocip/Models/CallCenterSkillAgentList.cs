using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of agents for a particular skill Level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7712""}]")]
    public class CallCenterSkillAgentList
    {

        private int _skillLevel;

        [XmlElement(ElementName = "skillLevel", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7712")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int SkillLevel
        {
            get => _skillLevel;
            set
            {
                SkillLevelSpecified = true;
                _skillLevel = value;
            }
        }

        [XmlIgnore]
        protected bool SkillLevelSpecified { get; set; }

        private List<string> _agent = new List<string>();

        [XmlElement(ElementName = "agent", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7712")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> Agent
        {
            get => _agent;
            set
            {
                AgentSpecified = true;
                _agent = value;
            }
        }

        [XmlIgnore]
        protected bool AgentSpecified { get; set; }

    }
}
