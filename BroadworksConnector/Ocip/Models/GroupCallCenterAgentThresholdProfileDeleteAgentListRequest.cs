using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterAgentThresholdProfileDeleteAgentListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "profileName", IsNullable = false)]
    public string ProfileName { get; set; }
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public List<string> AgentUserId { get; set; }
 }
}
