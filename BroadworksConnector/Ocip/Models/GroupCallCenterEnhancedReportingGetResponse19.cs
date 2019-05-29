using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingGetResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "reportingServer", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportServerChoice19 ReportingServer { get; set; }
 }
}
