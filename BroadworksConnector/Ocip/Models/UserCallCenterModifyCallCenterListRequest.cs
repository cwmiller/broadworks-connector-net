using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterModifyCallCenterListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public string AgentUserId { get; set; }
    [XmlElement(ElementName = "serviceUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList ServiceUserIdList { get; set; }
 }
}
