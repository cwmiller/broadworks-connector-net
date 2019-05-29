using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupConsolidatedAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false)]
    public bool AddPhoneNumberToGroup { get; set; }
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
    [XmlElement(ElementName = "agentWeight", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.HuntAgentWeight> AgentWeight { get; set; }
    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false)]
    public bool AllowCallWaitingForAgents { get; set; }
    [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false)]
    public bool UseSystemHuntGroupCLIDSetting { get; set; }
    [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false)]
    public bool IncludeHuntGroupNameInCLID { get; set; }
    [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false)]
    public bool EnableNotReachableForwarding { get; set; }
    [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = false)]
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
    [XmlElement(ElementName = "service", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> Service { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "directoryNumberHuntingAgentUserIdList", IsNullable = false)]
    public List<string> DirectoryNumberHuntingAgentUserIdList { get; set; }
    [XmlElement(ElementName = "directoryNumberHuntingUseTerminateCallToAgentFirst", IsNullable = false)]
    public bool DirectoryNumberHuntingUseTerminateCallToAgentFirst { get; set; }
    [XmlElement(ElementName = "directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false)]
    public bool DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls { get; set; }
 }
}
