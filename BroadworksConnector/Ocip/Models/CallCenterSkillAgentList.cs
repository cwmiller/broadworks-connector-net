using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of agents for a particular skill Level.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterSkillAgentList 
    {

        
        private int _skillLevel;

        [XmlElement(ElementName = "skillLevel", IsNullable = false, Namespace = "")]
        public int SkillLevel {
            get => _skillLevel;
            set {
                SkillLevelSpecified = true;
                _skillLevel = value;
            }
        }

        [XmlIgnore]
        public bool SkillLevelSpecified { get; set; }
        
        private List<string> _agent;

        [XmlElement(ElementName = "agent", IsNullable = false, Namespace = "")]
        public List<string> Agent {
            get => _agent;
            set {
                AgentSpecified = true;
                _agent = value;
            }
        }

        [XmlIgnore]
        public bool AgentSpecified { get; set; }
        
    }
}
