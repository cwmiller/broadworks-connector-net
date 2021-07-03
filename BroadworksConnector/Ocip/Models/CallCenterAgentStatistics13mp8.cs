using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center statistics for a specified agent.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47640""}]")]
    public class CallCenterAgentStatistics13mp8
    {

        private string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47640")]
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
        protected bool AgentUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserDisplayNames _agentDisplayNames;

        [XmlElement(ElementName = "agentDisplayNames", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47640")]
        public BroadWorksConnector.Ocip.Models.UserDisplayNames AgentDisplayNames
        {
            get => _agentDisplayNames;
            set
            {
                AgentDisplayNamesSpecified = true;
                _agentDisplayNames = value;
            }
        }

        [XmlIgnore]
        protected bool AgentDisplayNamesSpecified { get; set; }

        private bool _available;

        [XmlElement(ElementName = "available", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47640")]
        public bool Available
        {
            get => _available;
            set
            {
                AvailableSpecified = true;
                _available = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 _statisticsYesterday;

        [XmlElement(ElementName = "statisticsYesterday", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47640")]
        public BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 StatisticsYesterday
        {
            get => _statisticsYesterday;
            set
            {
                StatisticsYesterdaySpecified = true;
                _statisticsYesterday = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsYesterdaySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 _statisticsToday;

        [XmlElement(ElementName = "statisticsToday", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47640")]
        public BroadWorksConnector.Ocip.Models.CallCenterAgentDailyStatistics13mp8 StatisticsToday
        {
            get => _statisticsToday;
            set
            {
                StatisticsTodaySpecified = true;
                _statisticsToday = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsTodaySpecified { get; set; }

    }
}
