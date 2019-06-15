using System;
using System.Xml.Serialization;
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
     
    public class GroupCallCenterGetInstanceStatisticsResponse13mp8 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _numberOfCallsQueuedNow;

        [XmlElement(ElementName = "numberOfCallsQueuedNow", IsNullable = false, Namespace = "")]
        public int NumberOfCallsQueuedNow {
            get => _numberOfCallsQueuedNow;
            set {
                NumberOfCallsQueuedNowSpecified = true;
                _numberOfCallsQueuedNow = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfCallsQueuedNowSpecified { get; set; }
        
        private bool _generateDailyReport;

        [XmlElement(ElementName = "generateDailyReport", IsNullable = false, Namespace = "")]
        public bool GenerateDailyReport {
            get => _generateDailyReport;
            set {
                GenerateDailyReportSpecified = true;
                _generateDailyReport = value;
            }
        }

        [XmlIgnore]
        public bool GenerateDailyReportSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes _collectionPeriodMinutes;

        [XmlElement(ElementName = "collectionPeriodMinutes", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsCollectionPeriodMinutes CollectionPeriodMinutes {
            get => _collectionPeriodMinutes;
            set {
                CollectionPeriodMinutesSpecified = true;
                _collectionPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        public bool CollectionPeriodMinutesSpecified { get; set; }
        
        private string _reportingEmailAddress1;

        [XmlElement(ElementName = "reportingEmailAddress1", IsNullable = false, Namespace = "")]
        public string ReportingEmailAddress1 {
            get => _reportingEmailAddress1;
            set {
                ReportingEmailAddress1Specified = true;
                _reportingEmailAddress1 = value;
            }
        }

        [XmlIgnore]
        public bool ReportingEmailAddress1Specified { get; set; }
        
        private string _reportingEmailAddress2;

        [XmlElement(ElementName = "reportingEmailAddress2", IsNullable = false, Namespace = "")]
        public string ReportingEmailAddress2 {
            get => _reportingEmailAddress2;
            set {
                ReportingEmailAddress2Specified = true;
                _reportingEmailAddress2 = value;
            }
        }

        [XmlIgnore]
        public bool ReportingEmailAddress2Specified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 _queueStatisticsYesterday;

        [XmlElement(ElementName = "queueStatisticsYesterday", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 QueueStatisticsYesterday {
            get => _queueStatisticsYesterday;
            set {
                QueueStatisticsYesterdaySpecified = true;
                _queueStatisticsYesterday = value;
            }
        }

        [XmlIgnore]
        public bool QueueStatisticsYesterdaySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 _queueStatisticsToday;

        [XmlElement(ElementName = "queueStatisticsToday", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterQueueStatistics13mp8 QueueStatisticsToday {
            get => _queueStatisticsToday;
            set {
                QueueStatisticsTodaySpecified = true;
                _queueStatisticsToday = value;
            }
        }

        [XmlIgnore]
        public bool QueueStatisticsTodaySpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics13mp8> _agentStatistics;

        [XmlElement(ElementName = "agentStatistics", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterAgentStatistics13mp8> AgentStatistics {
            get => _agentStatistics;
            set {
                AgentStatisticsSpecified = true;
                _agentStatistics = value;
            }
        }

        [XmlIgnore]
        public bool AgentStatisticsSpecified { get; set; }
        
    }
}
