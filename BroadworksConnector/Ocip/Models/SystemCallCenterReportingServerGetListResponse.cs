using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterReportingServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "reportingServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ReportingServerTable { get; set; }
 }
}
