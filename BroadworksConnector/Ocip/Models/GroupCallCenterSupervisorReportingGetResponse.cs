using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterSupervisorReportingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "reportingServerName", IsNullable = false)]
    public string ReportingServerName { get; set; }
    [XmlElement(ElementName = "supervisorTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SupervisorTable { get; set; }
 }
}
