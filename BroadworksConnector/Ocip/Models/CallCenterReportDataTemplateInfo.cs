using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center reporting data template info.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7398""}]")]
    public class CallCenterReportDataTemplateInfo
    {

        private string _dataTemplate;

        [XmlElement(ElementName = "dataTemplate", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DataTemplate
        {
            get => _dataTemplate;
            set
            {
                DataTemplateSpecified = true;
                _dataTemplate = value;
            }
        }

        [XmlIgnore]
        protected bool DataTemplateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportType _reportType;

        [XmlElement(ElementName = "reportType", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportType ReportType
        {
            get => _reportType;
            set
            {
                ReportTypeSpecified = true;
                _reportType = value;
            }
        }

        [XmlIgnore]
        protected bool ReportTypeSpecified { get; set; }

        private bool _isRealtimeReport;

        [XmlElement(ElementName = "isRealtimeReport", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public bool IsRealtimeReport
        {
            get => _isRealtimeReport;
            set
            {
                IsRealtimeReportSpecified = true;
                _isRealtimeReport = value;
            }
        }

        [XmlIgnore]
        protected bool IsRealtimeReportSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isAgentParamRequired;

        [XmlElement(ElementName = "isAgentParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsAgentParamRequired
        {
            get => _isAgentParamRequired;
            set
            {
                IsAgentParamRequiredSpecified = true;
                _isAgentParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsAgentParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isCallCenterParamRequired;

        [XmlElement(ElementName = "isCallCenterParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCenterParamRequired
        {
            get => _isCallCenterParamRequired;
            set
            {
                IsCallCenterParamRequiredSpecified = true;
                _isCallCenterParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsCallCenterParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isCallCenterDnisParamRequired;

        [XmlElement(ElementName = "isCallCenterDnisParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCenterDnisParamRequired
        {
            get => _isCallCenterDnisParamRequired;
            set
            {
                IsCallCenterDnisParamRequiredSpecified = true;
                _isCallCenterDnisParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsCallCenterDnisParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isSamplingPeriodParamRequired;

        [XmlElement(ElementName = "isSamplingPeriodParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsSamplingPeriodParamRequired
        {
            get => _isSamplingPeriodParamRequired;
            set
            {
                IsSamplingPeriodParamRequiredSpecified = true;
                _isSamplingPeriodParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsSamplingPeriodParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isCallCompletionThresholdParamRequired;

        [XmlElement(ElementName = "isCallCompletionThresholdParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCompletionThresholdParamRequired
        {
            get => _isCallCompletionThresholdParamRequired;
            set
            {
                IsCallCompletionThresholdParamRequiredSpecified = true;
                _isCallCompletionThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsCallCompletionThresholdParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isShortDurationThresholdParamRequired;

        [XmlElement(ElementName = "isShortDurationThresholdParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsShortDurationThresholdParamRequired
        {
            get => _isShortDurationThresholdParamRequired;
            set
            {
                IsShortDurationThresholdParamRequiredSpecified = true;
                _isShortDurationThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsShortDurationThresholdParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isServiceLevelThresholdParamRequired;

        [XmlElement(ElementName = "isServiceLevelThresholdParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelThresholdParamRequired
        {
            get => _isServiceLevelThresholdParamRequired;
            set
            {
                IsServiceLevelThresholdParamRequiredSpecified = true;
                _isServiceLevelThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsServiceLevelThresholdParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isServiceLevelInclusionsParamRequired;

        [XmlElement(ElementName = "isServiceLevelInclusionsParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelInclusionsParamRequired
        {
            get => _isServiceLevelInclusionsParamRequired;
            set
            {
                IsServiceLevelInclusionsParamRequiredSpecified = true;
                _isServiceLevelInclusionsParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsServiceLevelInclusionsParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isServiceLevelObjectiveThresholdParamRequired;

        [XmlElement(ElementName = "isServiceLevelObjectiveThresholdParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelObjectiveThresholdParamRequired
        {
            get => _isServiceLevelObjectiveThresholdParamRequired;
            set
            {
                IsServiceLevelObjectiveThresholdParamRequiredSpecified = true;
                _isServiceLevelObjectiveThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsServiceLevelObjectiveThresholdParamRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isAbandonedCallThresholdParamRequired;

        [XmlElement(ElementName = "isAbandonedCallThresholdParamRequired", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7398")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsAbandonedCallThresholdParamRequired
        {
            get => _isAbandonedCallThresholdParamRequired;
            set
            {
                IsAbandonedCallThresholdParamRequiredSpecified = true;
                _isAbandonedCallThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        protected bool IsAbandonedCallThresholdParamRequiredSpecified { get; set; }

    }
}
