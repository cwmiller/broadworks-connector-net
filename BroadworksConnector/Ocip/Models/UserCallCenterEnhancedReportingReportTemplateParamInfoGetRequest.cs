using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey _reportTemplate;

    [XmlElement(ElementName = "reportTemplate", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate {
        get => _reportTemplate;
        set {
            ReportTemplateSpecified = true;
            _reportTemplate = value;
        }
    }

    [XmlIgnore]
    public bool ReportTemplateSpecified { get; set; }
}
}
