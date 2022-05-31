using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center statistics.
    /// Replaced By: GroupCallCenterGetInstanceStatisticsResponse14sp9
    /// <see cref="GroupCallCenterGetInstanceStatisticsResponse14sp9"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6174""}]")]
    public class GroupCallCenterGetInstanceStatisticsResponse13mp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _numberOfCallsQueuedNow;

        [XmlElement(ElementName = "numberOfCallsQueuedNow", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        public int NumberOfCallsQueuedNow
        {
            get => _numberOfCallsQueuedNow;
            set
            {
                NumberOfCallsQueuedNowSpecified = true;
                _numberOfCallsQueuedNow = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsQueuedNowSpecified { get; set; }

        protected bool _generateDailyReport;

        [XmlElement(ElementName = "generateDailyReport", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        public bool GenerateDailyReport
        {
            get => _generateDailyReport;
            set
            {
                GenerateDailyReportSpecified = true;
                _generateDailyReport = value;
            }
        }

        [XmlIgnore]
        protected bool GenerateDailyReportSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes _collectionPeriodMinutes;

        [XmlElement(ElementName = "collectionPeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes CollectionPeriodMinutes
        {
            get => _collectionPeriodMinutes;
            set
            {
                CollectionPeriodMinutesSpecified = true;
                _collectionPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool CollectionPeriodMinutesSpecified { get; set; }

        protected string _reportingEmailAddress1;

        [XmlElement(ElementName = "reportingEmailAddress1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ReportingEmailAddress1
        {
            get => _reportingEmailAddress1;
            set
            {
                ReportingEmailAddress1Specified = true;
                _reportingEmailAddress1 = value;
            }
        }

        [XmlIgnore]
        protected bool ReportingEmailAddress1Specified { get; set; }

        protected string _reportingEmailAddress2;

        [XmlElement(ElementName = "reportingEmailAddress2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ReportingEmailAddress2
        {
            get => _reportingEmailAddress2;
            set
            {
                ReportingEmailAddress2Specified = true;
                _reportingEmailAddress2 = value;
            }
        }

        [XmlIgnore]
        protected bool ReportingEmailAddress2Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 _queueStatisticsYesterday;

        [XmlElement(ElementName = "queueStatisticsYesterday", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        public BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 QueueStatisticsYesterday
        {
            get => _queueStatisticsYesterday;
            set
            {
                QueueStatisticsYesterdaySpecified = true;
                _queueStatisticsYesterday = value;
            }
        }

        [XmlIgnore]
        protected bool QueueStatisticsYesterdaySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 _queueStatisticsToday;

        [XmlElement(ElementName = "queueStatisticsToday", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        public BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 QueueStatisticsToday
        {
            get => _queueStatisticsToday;
            set
            {
                QueueStatisticsTodaySpecified = true;
                _queueStatisticsToday = value;
            }
        }

        [XmlIgnore]
        protected bool QueueStatisticsTodaySpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics13mp8> _agentStatistics = new List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics13mp8>();

        [XmlElement(ElementName = "agentStatistics", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6174")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics13mp8> AgentStatistics
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
