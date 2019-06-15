using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest.
        /// <see cref="UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private bool _requireAgentParam;

        [XmlElement(ElementName = "requireAgentParam", IsNullable = false, Namespace = "")]
        public bool RequireAgentParam {
            get => _requireAgentParam;
            set {
                RequireAgentParamSpecified = true;
                _requireAgentParam = value;
            }
        }

        [XmlIgnore]
        public bool RequireAgentParamSpecified { get; set; }
        
        private bool _requireCallCenterParam;

        [XmlElement(ElementName = "requireCallCenterParam", IsNullable = false, Namespace = "")]
        public bool RequireCallCenterParam {
            get => _requireCallCenterParam;
            set {
                RequireCallCenterParamSpecified = true;
                _requireCallCenterParam = value;
            }
        }

        [XmlIgnore]
        public bool RequireCallCenterParamSpecified { get; set; }
        
        private bool _requireCallCenterDnisParam;

        [XmlElement(ElementName = "requireCallCenterDnisParam", IsNullable = false, Namespace = "")]
        public bool RequireCallCenterDnisParam {
            get => _requireCallCenterDnisParam;
            set {
                RequireCallCenterDnisParamSpecified = true;
                _requireCallCenterDnisParam = value;
            }
        }

        [XmlIgnore]
        public bool RequireCallCenterDnisParamSpecified { get; set; }
        
        private bool _requireSamplingPeriodParam;

        [XmlElement(ElementName = "requireSamplingPeriodParam", IsNullable = false, Namespace = "")]
        public bool RequireSamplingPeriodParam {
            get => _requireSamplingPeriodParam;
            set {
                RequireSamplingPeriodParamSpecified = true;
                _requireSamplingPeriodParam = value;
            }
        }

        [XmlIgnore]
        public bool RequireSamplingPeriodParamSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _callCompletionThresholdParam;

        [XmlElement(ElementName = "callCompletionThresholdParam", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption CallCompletionThresholdParam {
            get => _callCompletionThresholdParam;
            set {
                CallCompletionThresholdParamSpecified = true;
                _callCompletionThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool CallCompletionThresholdParamSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _shortDurationThresholdParam;

        [XmlElement(ElementName = "shortDurationThresholdParam", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ShortDurationThresholdParam {
            get => _shortDurationThresholdParam;
            set {
                ShortDurationThresholdParamSpecified = true;
                _shortDurationThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool ShortDurationThresholdParamSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelThresholdParam;

        [XmlElement(ElementName = "serviceLevelThresholdParam", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelThresholdParam {
            get => _serviceLevelThresholdParam;
            set {
                ServiceLevelThresholdParamSpecified = true;
                _serviceLevelThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelThresholdParamSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelInclusionsParam;

        [XmlElement(ElementName = "serviceLevelInclusionsParam", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelInclusionsParam {
            get => _serviceLevelInclusionsParam;
            set {
                ServiceLevelInclusionsParamSpecified = true;
                _serviceLevelInclusionsParam = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelInclusionsParamSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelObjectiveThresholdParam;

        [XmlElement(ElementName = "serviceLevelObjectiveThresholdParam", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelObjectiveThresholdParam {
            get => _serviceLevelObjectiveThresholdParam;
            set {
                ServiceLevelObjectiveThresholdParamSpecified = true;
                _serviceLevelObjectiveThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelObjectiveThresholdParamSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _abandonedCallThresholdParam;

        [XmlElement(ElementName = "abandonedCallThresholdParam", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption AbandonedCallThresholdParam {
            get => _abandonedCallThresholdParam;
            set {
                AbandonedCallThresholdParamSpecified = true;
                _abandonedCallThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool AbandonedCallThresholdParamSpecified { get; set; }
        
        private int _serviceLevelThresholdParamNumber;

        [XmlElement(ElementName = "serviceLevelThresholdParamNumber", IsNullable = false, Namespace = "")]
        public int ServiceLevelThresholdParamNumber {
            get => _serviceLevelThresholdParamNumber;
            set {
                ServiceLevelThresholdParamNumberSpecified = true;
                _serviceLevelThresholdParamNumber = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelThresholdParamNumberSpecified { get; set; }
        
        private int _abandonedCallThresholdParamNumber;

        [XmlElement(ElementName = "abandonedCallThresholdParamNumber", IsNullable = false, Namespace = "")]
        public int AbandonedCallThresholdParamNumber {
            get => _abandonedCallThresholdParamNumber;
            set {
                AbandonedCallThresholdParamNumberSpecified = true;
                _abandonedCallThresholdParamNumber = value;
            }
        }

        [XmlIgnore]
        public bool AbandonedCallThresholdParamNumberSpecified { get; set; }
        
    }
}
