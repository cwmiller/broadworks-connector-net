using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest.
    /// <see cref="UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6778""}]")]
    public class UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isRealtimeReport;

        [XmlElement(ElementName = "isRealtimeReport", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
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

        private bool _requireAgentParam;

        [XmlElement(ElementName = "requireAgentParam", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public bool RequireAgentParam
        {
            get => _requireAgentParam;
            set
            {
                RequireAgentParamSpecified = true;
                _requireAgentParam = value;
            }
        }

        [XmlIgnore]
        protected bool RequireAgentParamSpecified { get; set; }

        private bool _requireCallCenterParam;

        [XmlElement(ElementName = "requireCallCenterParam", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public bool RequireCallCenterParam
        {
            get => _requireCallCenterParam;
            set
            {
                RequireCallCenterParamSpecified = true;
                _requireCallCenterParam = value;
            }
        }

        [XmlIgnore]
        protected bool RequireCallCenterParamSpecified { get; set; }

        private bool _requireCallCenterDnisParam;

        [XmlElement(ElementName = "requireCallCenterDnisParam", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public bool RequireCallCenterDnisParam
        {
            get => _requireCallCenterDnisParam;
            set
            {
                RequireCallCenterDnisParamSpecified = true;
                _requireCallCenterDnisParam = value;
            }
        }

        [XmlIgnore]
        protected bool RequireCallCenterDnisParamSpecified { get; set; }

        private bool _requireSamplingPeriodParam;

        [XmlElement(ElementName = "requireSamplingPeriodParam", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public bool RequireSamplingPeriodParam
        {
            get => _requireSamplingPeriodParam;
            set
            {
                RequireSamplingPeriodParamSpecified = true;
                _requireSamplingPeriodParam = value;
            }
        }

        [XmlIgnore]
        protected bool RequireSamplingPeriodParamSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _callCompletionThresholdParam;

        [XmlElement(ElementName = "callCompletionThresholdParam", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption CallCompletionThresholdParam
        {
            get => _callCompletionThresholdParam;
            set
            {
                CallCompletionThresholdParamSpecified = true;
                _callCompletionThresholdParam = value;
            }
        }

        [XmlIgnore]
        protected bool CallCompletionThresholdParamSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _shortDurationThresholdParam;

        [XmlElement(ElementName = "shortDurationThresholdParam", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ShortDurationThresholdParam
        {
            get => _shortDurationThresholdParam;
            set
            {
                ShortDurationThresholdParamSpecified = true;
                _shortDurationThresholdParam = value;
            }
        }

        [XmlIgnore]
        protected bool ShortDurationThresholdParamSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelThresholdParam;

        [XmlElement(ElementName = "serviceLevelThresholdParam", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelThresholdParam
        {
            get => _serviceLevelThresholdParam;
            set
            {
                ServiceLevelThresholdParamSpecified = true;
                _serviceLevelThresholdParam = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceLevelThresholdParamSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelInclusionsParam;

        [XmlElement(ElementName = "serviceLevelInclusionsParam", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelInclusionsParam
        {
            get => _serviceLevelInclusionsParam;
            set
            {
                ServiceLevelInclusionsParamSpecified = true;
                _serviceLevelInclusionsParam = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceLevelInclusionsParamSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelObjectiveThresholdParam;

        [XmlElement(ElementName = "serviceLevelObjectiveThresholdParam", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelObjectiveThresholdParam
        {
            get => _serviceLevelObjectiveThresholdParam;
            set
            {
                ServiceLevelObjectiveThresholdParamSpecified = true;
                _serviceLevelObjectiveThresholdParam = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceLevelObjectiveThresholdParamSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _abandonedCallThresholdParam;

        [XmlElement(ElementName = "abandonedCallThresholdParam", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption AbandonedCallThresholdParam
        {
            get => _abandonedCallThresholdParam;
            set
            {
                AbandonedCallThresholdParamSpecified = true;
                _abandonedCallThresholdParam = value;
            }
        }

        [XmlIgnore]
        protected bool AbandonedCallThresholdParamSpecified { get; set; }

        private int _serviceLevelThresholdParamNumber;

        [XmlElement(ElementName = "serviceLevelThresholdParamNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int ServiceLevelThresholdParamNumber
        {
            get => _serviceLevelThresholdParamNumber;
            set
            {
                ServiceLevelThresholdParamNumberSpecified = true;
                _serviceLevelThresholdParamNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceLevelThresholdParamNumberSpecified { get; set; }

        private int _abandonedCallThresholdParamNumber;

        [XmlElement(ElementName = "abandonedCallThresholdParamNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6778")]
        [MinInclusive(1)]
        [MaxInclusive(4)]
        public int AbandonedCallThresholdParamNumber
        {
            get => _abandonedCallThresholdParamNumber;
            set
            {
                AbandonedCallThresholdParamNumberSpecified = true;
                _abandonedCallThresholdParamNumber = value;
            }
        }

        [XmlIgnore]
        protected bool AbandonedCallThresholdParamNumberSpecified { get; set; }

    }
}
