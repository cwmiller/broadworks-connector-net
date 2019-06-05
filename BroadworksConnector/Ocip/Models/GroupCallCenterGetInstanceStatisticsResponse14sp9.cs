using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterGetInstanceStatisticsResponse14sp9 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.CallCenterStatisticsRange _statisticsRange;

        [XmlElement(ElementName = "statisticsRange", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterStatisticsRange StatisticsRange
        {
            get => _statisticsRange;
            set
            {
                StatisticsRangeSpecified = true;
                _statisticsRange = value;
            }
        }

        [XmlIgnore]
        public bool StatisticsRangeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterQueueStatistics14sp9 _queueStatistics;

        [XmlElement(ElementName = "queueStatistics", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterQueueStatistics14sp9 QueueStatistics
        {
            get => _queueStatistics;
            set
            {
                QueueStatisticsSpecified = true;
                _queueStatistics = value;
            }
        }

        [XmlIgnore]
        public bool QueueStatisticsSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.CallCenterAgentStatistics14sp9> _agentStatistics;

        [XmlElement(ElementName = "agentStatistics", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.CallCenterAgentStatistics14sp9> AgentStatistics
        {
            get => _agentStatistics;
            set
            {
                AgentStatisticsSpecified = true;
                _agentStatistics = value;
            }
        }

        [XmlIgnore]
        public bool AgentStatisticsSpecified { get; set; }
    }
}
