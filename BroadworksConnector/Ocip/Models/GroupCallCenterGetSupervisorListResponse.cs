using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetSupervisorListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "reportingServerURL", IsNullable = false)]
    public string ReportingServerURL { get; set; }
    [XmlElement(ElementName = "supervisorTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SupervisorTable { get; set; }
 }
}
