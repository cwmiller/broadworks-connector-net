using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifySupervisorListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "reportingServerURL", IsNullable = true)]
    public string ReportingServerURL { get; set; }
    [XmlElement(ElementName = "supervisorUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList SupervisorUserIdList { get; set; }
 }
}
