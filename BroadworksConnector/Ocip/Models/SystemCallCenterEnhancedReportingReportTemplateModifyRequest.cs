using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingReportTemplateModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _xsltTemplate;

    [XmlElement(ElementName = "xsltTemplate", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource XsltTemplate {
        get => _xsltTemplate;
        set {
            XsltTemplateSpecified = true;
            _xsltTemplate = value;
        }
    }

    [XmlIgnore]
    public bool XsltTemplateSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateAccessOption _scope;

    [XmlElement(ElementName = "scope", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateAccessOption Scope {
        get => _scope;
        set {
            ScopeSpecified = true;
            _scope = value;
        }
    }

    [XmlIgnore]
    public bool ScopeSpecified { get; set; }
    private bool _isEnabled;

    [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
    public bool IsEnabled {
        get => _isEnabled;
        set {
            IsEnabledSpecified = true;
            _isEnabled = value;
        }
    }

    [XmlIgnore]
    public bool IsEnabledSpecified { get; set; }
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
    private int? _filterNumber;

    [XmlElement(ElementName = "filterNumber", IsNullable = true, Namespace = "")]
    public int? FilterNumber {
        get => _filterNumber;
        set {
            FilterNumberSpecified = true;
            _filterNumber = value;
        }
    }

    [XmlIgnore]
    public bool FilterNumberSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateQueryFilterValueReplacementList _filterValue;

    [XmlElement(ElementName = "filterValue", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateQueryFilterValueReplacementList FilterValue {
        get => _filterValue;
        set {
            FilterValueSpecified = true;
            _filterValue = value;
        }
    }

    [XmlIgnore]
    public bool FilterValueSpecified { get; set; }
}
}
