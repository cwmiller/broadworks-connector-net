using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduledReportTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ScheduledReportTable { get; set; }
 }
}
