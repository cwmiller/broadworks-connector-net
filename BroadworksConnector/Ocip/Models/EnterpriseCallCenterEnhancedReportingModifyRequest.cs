using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "reportingServer", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportServerChoice ReportingServer { get; set; }
    [XmlElement(ElementName = "webStatisticSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportWebStatisticsSource WebStatisticSource { get; set; }
 }
}
