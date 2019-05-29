using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingDataTemplateGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "info", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCenterReportDataTemplateInfo> Info { get; set; }
 }
}
