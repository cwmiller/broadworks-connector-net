using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center reporting data template info.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterReportDataTemplateInfo 
    {

        
        private string _dataTemplate;

        [XmlElement(ElementName = "dataTemplate", IsNullable = false, Namespace = "")]
        public string DataTemplate {
            get => _dataTemplate;
            set {
                DataTemplateSpecified = true;
                _dataTemplate = value;
            }
        }

        [XmlIgnore]
        public bool DataTemplateSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportType _reportType;

        [XmlElement(ElementName = "reportType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportType ReportType {
            get => _reportType;
            set {
                ReportTypeSpecified = true;
                _reportType = value;
            }
        }

        [XmlIgnore]
        public bool ReportTypeSpecified { get; set; }
        
        private bool _isRealtimeReport;

        [XmlElement(ElementName = "isRealtimeReport", IsNullable = false, Namespace = "")]
        public bool IsRealtimeReport {
            get => _isRealtimeReport;
            set {
                IsRealtimeReportSpecified = true;
                _isRealtimeReport = value;
            }
        }

        [XmlIgnore]
        public bool IsRealtimeReportSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isAgentParamRequired;

        [XmlElement(ElementName = "isAgentParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsAgentParamRequired {
            get => _isAgentParamRequired;
            set {
                IsAgentParamRequiredSpecified = true;
                _isAgentParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsAgentParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isCallCenterParamRequired;

        [XmlElement(ElementName = "isCallCenterParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCenterParamRequired {
            get => _isCallCenterParamRequired;
            set {
                IsCallCenterParamRequiredSpecified = true;
                _isCallCenterParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsCallCenterParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isCallCenterDnisParamRequired;

        [XmlElement(ElementName = "isCallCenterDnisParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCenterDnisParamRequired {
            get => _isCallCenterDnisParamRequired;
            set {
                IsCallCenterDnisParamRequiredSpecified = true;
                _isCallCenterDnisParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsCallCenterDnisParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isSamplingPeriodParamRequired;

        [XmlElement(ElementName = "isSamplingPeriodParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsSamplingPeriodParamRequired {
            get => _isSamplingPeriodParamRequired;
            set {
                IsSamplingPeriodParamRequiredSpecified = true;
                _isSamplingPeriodParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsSamplingPeriodParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isCallCompletionThresholdParamRequired;

        [XmlElement(ElementName = "isCallCompletionThresholdParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsCallCompletionThresholdParamRequired {
            get => _isCallCompletionThresholdParamRequired;
            set {
                IsCallCompletionThresholdParamRequiredSpecified = true;
                _isCallCompletionThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsCallCompletionThresholdParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isShortDurationThresholdParamRequired;

        [XmlElement(ElementName = "isShortDurationThresholdParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsShortDurationThresholdParamRequired {
            get => _isShortDurationThresholdParamRequired;
            set {
                IsShortDurationThresholdParamRequiredSpecified = true;
                _isShortDurationThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsShortDurationThresholdParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isServiceLevelThresholdParamRequired;

        [XmlElement(ElementName = "isServiceLevelThresholdParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelThresholdParamRequired {
            get => _isServiceLevelThresholdParamRequired;
            set {
                IsServiceLevelThresholdParamRequiredSpecified = true;
                _isServiceLevelThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsServiceLevelThresholdParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isServiceLevelInclusionsParamRequired;

        [XmlElement(ElementName = "isServiceLevelInclusionsParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelInclusionsParamRequired {
            get => _isServiceLevelInclusionsParamRequired;
            set {
                IsServiceLevelInclusionsParamRequiredSpecified = true;
                _isServiceLevelInclusionsParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsServiceLevelInclusionsParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isServiceLevelObjectiveThresholdParamRequired;

        [XmlElement(ElementName = "isServiceLevelObjectiveThresholdParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsServiceLevelObjectiveThresholdParamRequired {
            get => _isServiceLevelObjectiveThresholdParamRequired;
            set {
                IsServiceLevelObjectiveThresholdParamRequiredSpecified = true;
                _isServiceLevelObjectiveThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsServiceLevelObjectiveThresholdParamRequiredSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption _isAbandonedCallThresholdParamRequired;

        [XmlElement(ElementName = "isAbandonedCallThresholdParamRequired", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInputParameterOption IsAbandonedCallThresholdParamRequired {
            get => _isAbandonedCallThresholdParamRequired;
            set {
                IsAbandonedCallThresholdParamRequiredSpecified = true;
                _isAbandonedCallThresholdParamRequired = value;
            }
        }

        [XmlIgnore]
        public bool IsAbandonedCallThresholdParamRequiredSpecified { get; set; }
        
    }
}
