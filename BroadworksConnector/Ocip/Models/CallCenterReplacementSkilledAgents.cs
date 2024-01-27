using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of agents grouped by skill levels.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7383""}]")]
    public class CallCenterReplacementSkilledAgents
    {

        protected int _skillLevel;

        [XmlElement(ElementName = "skillLevel", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7383")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agents;

        [XmlElement(ElementName = "agents", IsNullable = true, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7383")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList Agents
        {
            get => _agents;
            set
            {
                AgentsSpecified = true;
                _agents = value;
            }
        }

        [XmlIgnore]
        protected bool AgentsSpecified { get; set; }

    }
}
