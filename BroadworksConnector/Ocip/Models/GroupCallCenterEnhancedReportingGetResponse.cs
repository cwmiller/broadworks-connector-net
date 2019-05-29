using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "reportingServer", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportServerChoice ReportingServer { get; set; }
    [XmlElement(ElementName = "webStatisticSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportWebStatisticsSource WebStatisticSource { get; set; }
 }
}
