using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.CallCenterReportTemplateKey _reportTemplate;

    [XmlElement(ElementName = "reportTemplate", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate {
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
