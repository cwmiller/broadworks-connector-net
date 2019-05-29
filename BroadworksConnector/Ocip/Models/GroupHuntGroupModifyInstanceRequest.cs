using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
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
    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true)]
    public string ForwardToPhoneNumber { get; set; }
    [XmlElement(ElementName = "agentUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList { get; set; }
    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false)]
    public bool AllowCallWaitingForAgents { get; set; }
    [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false)]
    public bool UseSystemHuntGroupCLIDSetting { get; set; }
    [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false)]
    public bool IncludeHuntGroupNameInCLID { get; set; }
    [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false)]
    public bool EnableNotReachableForwarding { get; set; }
    [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = true)]
    public string NotReachableForwardToPhoneNumber { get; set; }
    [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false)]
    public bool MakeBusyWhenNotReachable { get; set; }
    [XmlElement(ElementName = "allowMembersToControlGroupBusy", IsNullable = false)]
    public bool AllowMembersToControlGroupBusy { get; set; }
    [XmlElement(ElementName = "enableGroupBusy", IsNullable = false)]
    public bool EnableGroupBusy { get; set; }
    [XmlElement(ElementName = "applyGroupBusyWhenTerminatingToAgent", IsNullable = false)]
    public bool ApplyGroupBusyWhenTerminatingToAgent { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
