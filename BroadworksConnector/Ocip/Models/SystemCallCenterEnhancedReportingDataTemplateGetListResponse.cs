using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingDataTemplateGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> _info;

    [XmlElement(ElementName = "info", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> Info {
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
