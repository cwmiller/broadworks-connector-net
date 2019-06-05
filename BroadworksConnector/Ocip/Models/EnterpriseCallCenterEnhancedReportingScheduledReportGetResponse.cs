using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCallCenterEnhancedReportingScheduledReportGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
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
        private BroadworksConnector.Ocip.Models.CallCenterReportTemplateKey _reportTemplate;

        [XmlElement(ElementName = "reportTemplate", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate
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
        private BroadworksConnector.Ocip.Models.CallCenterReportSchedule _schedule;

        [XmlElement(ElementName = "schedule", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportSchedule Schedule
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
        private BroadworksConnector.Ocip.Models.CallCenterReportSamplingPeriod _samplingPeriod;

        [XmlElement(ElementName = "samplingPeriod", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportSamplingPeriod SamplingPeriod
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
        private BroadworksConnector.Ocip.Models.DayOfWeek _startDayOfWeek;

        [XmlElement(ElementName = "startDayOfWeek", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.DayOfWeek StartDayOfWeek
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
        private BroadworksConnector.Ocip.Models.CallCenterReportDateFormat _reportDateFormat;

        [XmlElement(ElementName = "reportDateFormat", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportDateFormat ReportDateFormat
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
        private BroadworksConnector.Ocip.Models.CallCenterReportTimeFormat _reportTimeFormat;

        [XmlElement(ElementName = "reportTimeFormat", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportTimeFormat ReportTimeFormat
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
        private BroadworksConnector.Ocip.Models.CallCenterReportInterval _reportInterval;

        [XmlElement(ElementName = "reportInterval", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportInterval ReportInterval
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
        private BroadworksConnector.Ocip.Models.CallCenterReportFileFormat _reportFormat;

        [XmlElement(ElementName = "reportFormat", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportFileFormat ReportFormat
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
        private BroadworksConnector.Ocip.Models.CallCenterScheduledReportAgentSelectionAdminRead _agent;

        [XmlElement(ElementName = "agent", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterScheduledReportAgentSelectionAdminRead Agent
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
        private BroadworksConnector.Ocip.Models.CallCenterScheduledReportCallCenterSelectionRead _callCenter;

        [XmlElement(ElementName = "callCenter", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterScheduledReportCallCenterSelectionRead CallCenter
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
        private BroadworksConnector.Ocip.Models.CallCenterScheduledReportDNISSelectionRead _dnis;

        [XmlElement(ElementName = "dnis", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterScheduledReportDNISSelectionRead Dnis
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
        private List<int> _serviceLevelThresholdSeconds;

        [XmlElement(ElementName = "serviceLevelThresholdSeconds", IsNullable = false, Namespace = "")]
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
        private BroadworksConnector.Ocip.Models.CallCenterScheduledReportServiceLevelInclusions _serviceLevelInclusions;

        [XmlElement(ElementName = "serviceLevelInclusions", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterScheduledReportServiceLevelInclusions ServiceLevelInclusions
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
        private List<int> _abandonedCallThresholdSeconds;

        [XmlElement(ElementName = "abandonedCallThresholdSeconds", IsNullable = false, Namespace = "")]
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
        private List<string> _emailAddress;

        [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
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
