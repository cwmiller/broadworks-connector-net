using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterSupervisorReportingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "reportingServerName", IsNullable = true)]
    public string ReportingServerName { get; set; }
    [XmlElement(ElementName = "supervisorUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList SupervisorUserIdList { get; set; }
 }
}
