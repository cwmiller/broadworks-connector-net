using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center statistics for a specified agent.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterAgentStatistics14sp9 
    {

        
        private string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        public string AgentUserId {
            get => _agentUserId;
            set {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UserDisplayNames _agentDisplayNames;

        [XmlElement(ElementName = "agentDisplayNames", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserDisplayNames AgentDisplayNames {
            get => _agentDisplayNames;
            set {
                AgentDisplayNamesSpecified = true;
                _agentDisplayNames = value;
            }
        }

        [XmlIgnore]
        public bool AgentDisplayNamesSpecified { get; set; }
        
        private bool _available;

        [XmlElement(ElementName = "available", IsNullable = false, Namespace = "")]
        public bool Available {
            get => _available;
            set {
                AvailableSpecified = true;
                _available = value;
            }
        }

        [XmlIgnore]
        public bool AvailableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AgentStatistics _statistics;

        [XmlElement(ElementName = "statistics", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AgentStatistics Statistics {
            get => _statistics;
            set {
                StatisticsSpecified = true;
                _statistics = value;
            }
        }

        [XmlIgnore]
        public bool StatisticsSpecified { get; set; }
        
    }
}
