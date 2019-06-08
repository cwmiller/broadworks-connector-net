using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingDataTemplateGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> _info;

    [XmlElement(ElementName = "info", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> Info {
        get => _info;
        set {
            InfoSpecified = true;
            _info = value;
        }
    }

    [XmlIgnore]
    public bool InfoSpecified { get; set; }
}
}
