using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a system level call center report template.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6260""}]")]
    public class SystemCallCenterEnhancedReportingReportTemplateModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
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

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        protected bool NewNameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
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

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _xsltTemplate;

        [XmlElement(ElementName = "xsltTemplate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
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
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
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
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
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

        private int? _filterNumber;

        [XmlElement(ElementName = "filterNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int? FilterNumber
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

        private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateQueryFilterValueReplacementList _filterValue;

        [XmlElement(ElementName = "filterValue", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6260")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateQueryFilterValueReplacementList FilterValue
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
