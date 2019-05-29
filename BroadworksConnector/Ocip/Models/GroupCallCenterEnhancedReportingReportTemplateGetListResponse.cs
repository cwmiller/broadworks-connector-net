using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingReportTemplateGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "reportTemplateTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ReportTemplateTable { get; set; }
 }
}
