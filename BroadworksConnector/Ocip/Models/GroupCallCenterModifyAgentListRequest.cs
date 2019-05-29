using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyAgentListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "agentUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList { get; set; }
    [XmlElement(ElementName = "skilledAgentUserIdList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCenterReplacementSkilledAgents> SkilledAgentUserIdList { get; set; }
 }
}
