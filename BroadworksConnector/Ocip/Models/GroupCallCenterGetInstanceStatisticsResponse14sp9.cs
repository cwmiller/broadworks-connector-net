using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center statistics.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4733""}]")]
    public class GroupCallCenterGetInstanceStatisticsResponse14sp9 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterStatisticsRange _statisticsRange;

        [XmlElement(ElementName = "statisticsRange", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4733")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsRange StatisticsRange
        {
            get => _statisticsRange;
            set
            {
                StatisticsRangeSpecified = true;
                _statisticsRange = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsRangeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics14sp9 _queueStatistics;

        [XmlElement(ElementName = "queueStatistics", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4733")]
        public BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics14sp9 QueueStatistics
        {
            get => _queueStatistics;
            set
            {
                QueueStatisticsSpecified = true;
                _queueStatistics = value;
            }
        }

        [XmlIgnore]
        protected bool QueueStatisticsSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics14sp9> _agentStatistics = new List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics14sp9>();

        [XmlElement(ElementName = "agentStatistics", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4733")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics14sp9> AgentStatistics
        {
            get => _agentStatistics;
            set
            {
                AgentStatisticsSpecified = true;
                _agentStatistics = value;
            }
        }

        [XmlIgnore]
        protected bool AgentStatisticsSpecified { get; set; }

    }
}
