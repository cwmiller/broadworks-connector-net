using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a system level call center report template.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6136""}]")]
    public class SystemCallCenterEnhancedReportingReportTemplateAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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

        private string _dataTemplate;

        [XmlElement(ElementName = "dataTemplate", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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

        private int _filterNumber;

        [XmlElement(ElementName = "filterNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int FilterNumber
        {
            get => _filterNumber;
            set
            {
                FilterNumberSpecified = true;
                _filterNumber = value;
            }
        }

        [XmlIgnore]
        protected bool FilterNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _xsltTemplate;

        [XmlElement(ElementName = "xsltTemplate", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource XsltTemplate
        {
            get => _xsltTemplate;
            set
            {
                XsltTemplateSpecified = true;
                _xsltTemplate = value;
            }
        }

        [XmlIgnore]
        protected bool XsltTemplateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateAccessOption _scope;

        [XmlElement(ElementName = "scope", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateAccessOption Scope
        {
            get => _scope;
            set
            {
                ScopeSpecified = true;
                _scope = value;
            }
        }

        [XmlIgnore]
        protected bool ScopeSpecified { get; set; }

        private bool _isEnabled;

        [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                IsEnabledSpecified = true;
                _isEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool IsEnabledSpecified { get; set; }

        private bool _isRealtimeReport;

        [XmlElement(ElementName = "isRealtimeReport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterReportInputParameterOption _callCompletionThresholdParam;

        [XmlElement(ElementName = "callCompletionThresholdParam", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
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

        private List<string> _filterValue = new List<string>();

        [XmlElement(ElementName = "filterValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6136")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> FilterValue
        {
            get => _filterValue;
            set
            {
                FilterValueSpecified = true;
                _filterValue = value;
            }
        }

        [XmlIgnore]
        protected bool FilterValueSpecified { get; set; }

    }
}
