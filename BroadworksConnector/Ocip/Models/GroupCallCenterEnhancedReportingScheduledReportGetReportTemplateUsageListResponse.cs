using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduleReportTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ScheduleReportTable { get; set; }
 }
}
