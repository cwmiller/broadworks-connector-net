using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add an enterprise level call center reporting scheduled report.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after startDate.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1507"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1521"",""optional"":true}]}]")]
    public class EnterpriseCallCenterEnhancedReportingScheduledReportAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey _reportTemplate;

        [XmlElement(ElementName = "reportTemplate", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate
        {
            get => _reportTemplate;
            set
            {
                ReportTemplateSpecified = true;
                _reportTemplate = value;
            }
        }

        [XmlIgnore]
        protected bool ReportTemplateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportSchedule _schedule;

        [XmlElement(ElementName = "schedule", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportSchedule Schedule
        {
            get => _schedule;
            set
            {
                ScheduleSpecified = true;
                _schedule = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportSamplingPeriod _samplingPeriod;

        [XmlElement(ElementName = "samplingPeriod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportSamplingPeriod SamplingPeriod
        {
            get => _samplingPeriod;
            set
            {
                SamplingPeriodSpecified = true;
                _samplingPeriod = value;
            }
        }

        [XmlIgnore]
        protected bool SamplingPeriodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DayOfWeek _startDayOfWeek;

        [XmlElement(ElementName = "startDayOfWeek", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.DayOfWeek StartDayOfWeek
        {
            get => _startDayOfWeek;
            set
            {
                StartDayOfWeekSpecified = true;
                _startDayOfWeek = value;
            }
        }

        [XmlIgnore]
        protected bool StartDayOfWeekSpecified { get; set; }

        private string _reportTimeZone;

        [XmlElement(ElementName = "reportTimeZone", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinLength(1)]
        [MaxLength(127)]
        public string ReportTimeZone
        {
            get => _reportTimeZone;
            set
            {
                ReportTimeZoneSpecified = true;
                _reportTimeZone = value;
            }
        }

        [XmlIgnore]
        protected bool ReportTimeZoneSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDateFormat _reportDateFormat;

        [XmlElement(ElementName = "reportDateFormat", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDateFormat ReportDateFormat
        {
            get => _reportDateFormat;
            set
            {
                ReportDateFormatSpecified = true;
                _reportDateFormat = value;
            }
        }

        [XmlIgnore]
        protected bool ReportDateFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportTimeFormat _reportTimeFormat;

        [XmlElement(ElementName = "reportTimeFormat", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportTimeFormat ReportTimeFormat
        {
            get => _reportTimeFormat;
            set
            {
                ReportTimeFormatSpecified = true;
                _reportTimeFormat = value;
            }
        }

        [XmlIgnore]
        protected bool ReportTimeFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInterval _reportInterval;

        [XmlElement(ElementName = "reportInterval", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInterval ReportInterval
        {
            get => _reportInterval;
            set
            {
                ReportIntervalSpecified = true;
                _reportInterval = value;
            }
        }

        [XmlIgnore]
        protected bool ReportIntervalSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportFileFormat _reportFormat;

        [XmlElement(ElementName = "reportFormat", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportFileFormat ReportFormat
        {
            get => _reportFormat;
            set
            {
                ReportFormatSpecified = true;
                _reportFormat = value;
            }
        }

        [XmlIgnore]
        protected bool ReportFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportAgentSelection _agent;

        [XmlElement(ElementName = "agent", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterScheduledReportAgentSelection Agent
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

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportCallCenterSelection _callCenter;

        [XmlElement(ElementName = "callCenter", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1521")]
        public BroadWorksConnector.Ocip.Models.CallCenterScheduledReportCallCenterSelection CallCenter
        {
            get => _callCenter;
            set
            {
                CallCenterSpecified = true;
                _callCenter = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportDNISSelection _dnis;

        [XmlElement(ElementName = "dnis", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1521")]
        public BroadWorksConnector.Ocip.Models.CallCenterScheduledReportDNISSelection Dnis
        {
            get => _dnis;
            set
            {
                DnisSpecified = true;
                _dnis = value;
            }
        }

        [XmlIgnore]
        protected bool DnisSpecified { get; set; }

        private int _callCompletionThresholdSeconds;

        [XmlElement(ElementName = "callCompletionThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public int CallCompletionThresholdSeconds
        {
            get => _callCompletionThresholdSeconds;
            set
            {
                CallCompletionThresholdSecondsSpecified = true;
                _callCompletionThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool CallCompletionThresholdSecondsSpecified { get; set; }

        private int _shortDurationThresholdSeconds;

        [XmlElement(ElementName = "shortDurationThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public int ShortDurationThresholdSeconds
        {
            get => _shortDurationThresholdSeconds;
            set
            {
                ShortDurationThresholdSecondsSpecified = true;
                _shortDurationThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ShortDurationThresholdSecondsSpecified { get; set; }

        private List<int> _serviceLevelThresholdSeconds = new List<int>();

        [XmlElement(ElementName = "serviceLevelThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public List<int> ServiceLevelThresholdSeconds
        {
            get => _serviceLevelThresholdSeconds;
            set
            {
                ServiceLevelThresholdSecondsSpecified = true;
                _serviceLevelThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceLevelThresholdSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportServiceLevelInclusions _serviceLevelInclusions;

        [XmlElement(ElementName = "serviceLevelInclusions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        public BroadWorksConnector.Ocip.Models.CallCenterScheduledReportServiceLevelInclusions ServiceLevelInclusions
        {
            get => _serviceLevelInclusions;
            set
            {
                ServiceLevelInclusionsSpecified = true;
                _serviceLevelInclusions = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceLevelInclusionsSpecified { get; set; }

        private int _serviceLevelObjectivePercentage;

        [XmlElement(ElementName = "serviceLevelObjectivePercentage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
        public int ServiceLevelObjectivePercentage
        {
            get => _serviceLevelObjectivePercentage;
            set
            {
                ServiceLevelObjectivePercentageSpecified = true;
                _serviceLevelObjectivePercentage = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceLevelObjectivePercentageSpecified { get; set; }

        private List<int> _abandonedCallThresholdSeconds = new List<int>();

        [XmlElement(ElementName = "abandonedCallThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public List<int> AbandonedCallThresholdSeconds
        {
            get => _abandonedCallThresholdSeconds;
            set
            {
                AbandonedCallThresholdSecondsSpecified = true;
                _abandonedCallThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AbandonedCallThresholdSecondsSpecified { get; set; }

        private List<string> _emailAddress = new List<string>();

        [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1507")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> EmailAddress
        {
            get => _emailAddress;
            set
            {
                EmailAddressSpecified = true;
                _emailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool EmailAddressSpecified { get; set; }

    }
}
