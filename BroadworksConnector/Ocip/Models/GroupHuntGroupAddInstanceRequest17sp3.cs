using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupAddInstanceRequest17sp3 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "policy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HuntPolicy Policy { get; set; }
    [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false)]
    public bool HuntAfterNoAnswer { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public int NoAnswerNumberOfRings { get; set; }
    [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false)]
    public bool ForwardAfterTimeout { get; set; }
    [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false)]
    public int ForwardTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false)]
    public string ForwardToPhoneNumber { get; set; }
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public List<string> AgentUserId { get; set; }
    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false)]
    public bool AllowCallWaitingForAgents { get; set; }
    [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false)]
    public bool UseSystemHuntGroupCLIDSetting { get; set; }
    [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false)]
    public bool IncludeHuntGroupNameInCLID { get; set; }
 }
}
