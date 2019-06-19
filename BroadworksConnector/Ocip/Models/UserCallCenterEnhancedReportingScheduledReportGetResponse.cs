using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallCenterEnhancedReportingScheduledReportGetRequest.
    /// <see cref="UserCallCenterEnhancedReportingScheduledReportGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6814"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6826"",""optional"":true}]}]")]
    public class UserCallCenterEnhancedReportingScheduledReportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey _reportTemplate;

        [XmlElement(ElementName = "reportTemplate", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ReportTemplateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportSchedule _schedule;

        [XmlElement(ElementName = "schedule", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportSamplingPeriod _samplingPeriod;

        [XmlElement(ElementName = "samplingPeriod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool SamplingPeriodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DayOfWeek _startDayOfWeek;

        [XmlElement(ElementName = "startDayOfWeek", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool StartDayOfWeekSpecified { get; set; }

        private string _reportTimeZone;

        [XmlElement(ElementName = "reportTimeZone", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ReportTimeZoneSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDateFormat _reportDateFormat;

        [XmlElement(ElementName = "reportDateFormat", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ReportDateFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportTimeFormat _reportTimeFormat;

        [XmlElement(ElementName = "reportTimeFormat", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ReportTimeFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInterval _reportInterval;

        [XmlElement(ElementName = "reportInterval", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ReportIntervalSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportFileFormat _reportFormat;

        [XmlElement(ElementName = "reportFormat", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ReportFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportAgentSelectionRead _agent;

        [XmlElement(ElementName = "agent", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
        public BroadWorksConnector.Ocip.Models.CallCenterScheduledReportAgentSelectionRead Agent
        {
            get => _agent;
            set
            {
                AgentSpecified = true;
                _agent = value;
            }
        }

        [XmlIgnore]
        public bool AgentSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportCallCenterSelection _callCenter;

        [XmlElement(ElementName = "callCenter", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6826")]
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
        public bool CallCenterSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportDNISSelection _dnis;

        [XmlElement(ElementName = "dnis", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6826")]
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
        public bool DnisSpecified { get; set; }

        private int _callCompletionThresholdSeconds;

        [XmlElement(ElementName = "callCompletionThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool CallCompletionThresholdSecondsSpecified { get; set; }

        private int _shortDurationThresholdSeconds;

        [XmlElement(ElementName = "shortDurationThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ShortDurationThresholdSecondsSpecified { get; set; }

        private List<int> _serviceLevelThresholdSeconds = new List<int>();

        [XmlElement(ElementName = "serviceLevelThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ServiceLevelThresholdSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterScheduledReportServiceLevelInclusions _serviceLevelInclusions;

        [XmlElement(ElementName = "serviceLevelInclusions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ServiceLevelInclusionsSpecified { get; set; }

        private int _serviceLevelObjectivePercentage;

        [XmlElement(ElementName = "serviceLevelObjectivePercentage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool ServiceLevelObjectivePercentageSpecified { get; set; }

        private List<int> _abandonedCallThresholdSeconds = new List<int>();

        [XmlElement(ElementName = "abandonedCallThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool AbandonedCallThresholdSecondsSpecified { get; set; }

        private List<string> _emailAddress = new List<string>();

        [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6814")]
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
        public bool EmailAddressSpecified { get; set; }

    }
}
