using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupModifyInstanceWeightedCallDistributionRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "agentWeight", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.HuntAgentWeight> AgentWeight { get; set; }
 }
}
