using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedReportingReportTemplateGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
        private string _dataTemplate;

        [XmlElement(ElementName = "dataTemplate", IsNullable = false, Namespace = "")]
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
        public bool DataTemplateSpecified { get; set; }
        private int _filterNumber;

        [XmlElement(ElementName = "filterNumber", IsNullable = false, Namespace = "")]
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
        public bool FilterNumberSpecified { get; set; }
        private string _xsltTemplateDescription;

        [XmlElement(ElementName = "xsltTemplateDescription", IsNullable = false, Namespace = "")]
        public string XsltTemplateDescription
        {
            get => _xsltTemplateDescription;
            set
            {
                XsltTemplateDescriptionSpecified = true;
                _xsltTemplateDescription = value;
            }
        }

        [XmlIgnore]
        public bool XsltTemplateDescriptionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportTemplateAccessOption _scope;

        [XmlElement(ElementName = "scope", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportTemplateAccessOption Scope
        {
            get => _scope;
            set
            {
                ScopeSpecified = true;
                _scope = value;
            }
        }

        [XmlIgnore]
        public bool ScopeSpecified { get; set; }
        private bool _isEnabled;

        [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
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
        public bool IsEnabledSpecified { get; set; }
        private bool _isRealtimeReport;

        [XmlElement(ElementName = "isRealtimeReport", IsNullable = false, Namespace = "")]
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
        public bool IsRealtimeReportSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption _callCompletionThresholdParam;

        [XmlElement(ElementName = "callCompletionThresholdParam", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption CallCompletionThresholdParam
        {
            get => _callCompletionThresholdParam;
            set
            {
                CallCompletionThresholdParamSpecified = true;
                _callCompletionThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool CallCompletionThresholdParamSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption _shortDurationThresholdParam;

        [XmlElement(ElementName = "shortDurationThresholdParam", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ShortDurationThresholdParam
        {
            get => _shortDurationThresholdParam;
            set
            {
                ShortDurationThresholdParamSpecified = true;
                _shortDurationThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool ShortDurationThresholdParamSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelThresholdParam;

        [XmlElement(ElementName = "serviceLevelThresholdParam", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelThresholdParam
        {
            get => _serviceLevelThresholdParam;
            set
            {
                ServiceLevelThresholdParamSpecified = true;
                _serviceLevelThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelThresholdParamSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelInclusionsParam;

        [XmlElement(ElementName = "serviceLevelInclusionsParam", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelInclusionsParam
        {
            get => _serviceLevelInclusionsParam;
            set
            {
                ServiceLevelInclusionsParamSpecified = true;
                _serviceLevelInclusionsParam = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelInclusionsParamSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption _serviceLevelObjectiveThresholdParam;

        [XmlElement(ElementName = "serviceLevelObjectiveThresholdParam", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption ServiceLevelObjectiveThresholdParam
        {
            get => _serviceLevelObjectiveThresholdParam;
            set
            {
                ServiceLevelObjectiveThresholdParamSpecified = true;
                _serviceLevelObjectiveThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool ServiceLevelObjectiveThresholdParamSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption _abandonedCallThresholdParam;

        [XmlElement(ElementName = "abandonedCallThresholdParam", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportInputParameterOption AbandonedCallThresholdParam
        {
            get => _abandonedCallThresholdParam;
            set
            {
                AbandonedCallThresholdParamSpecified = true;
                _abandonedCallThresholdParam = value;
            }
        }

        [XmlIgnore]
        public bool AbandonedCallThresholdParamSpecified { get; set; }
        private int _serviceLevelThresholdParamNumber;

        [XmlElement(ElementName = "serviceLevelThresholdParamNumber", IsNullable = false, Namespace = "")]
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
        public bool ServiceLevelThresholdParamNumberSpecified { get; set; }
        private int _abandonedCallThresholdParamNumber;

        [XmlElement(ElementName = "abandonedCallThresholdParamNumber", IsNullable = false, Namespace = "")]
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
        public bool AbandonedCallThresholdParamNumberSpecified { get; set; }
        private List<string> _filterValue;

        [XmlElement(ElementName = "filterValue", IsNullable = false, Namespace = "")]
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
        public bool FilterValueSpecified { get; set; }
    }
}
