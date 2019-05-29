using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterAddInstanceRequest14sp9 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter ServiceInstanceProfile { get; set; }
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
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "queueLength", IsNullable = false)]
    public int QueueLength { get; set; }
    [XmlElement(ElementName = "allowAgentLogoff", IsNullable = false)]
    public bool AllowAgentLogoff { get; set; }
    [XmlElement(ElementName = "playMusicOnHold", IsNullable = false)]
    public bool PlayMusicOnHold { get; set; }
    [XmlElement(ElementName = "playComfortMessage", IsNullable = false)]
    public bool PlayComfortMessage { get; set; }
    [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false)]
    public int TimeBetweenComfortMessagesSeconds { get; set; }
    [XmlElement(ElementName = "enableGuardTimer", IsNullable = false)]
    public bool EnableGuardTimer { get; set; }
    [XmlElement(ElementName = "guardTimerSeconds", IsNullable = false)]
    public int GuardTimerSeconds { get; set; }
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public List<string> AgentUserId { get; set; }
    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false)]
    public bool AllowCallWaitingForAgents { get; set; }
    [XmlElement(ElementName = "allowCallsToAgentsInWrapUp", IsNullable = false)]
    public bool AllowCallsToAgentsInWrapUp { get; set; }
    [XmlElement(ElementName = "enableCallQueueWhenNoAgentsAvailable", IsNullable = false)]
    public bool EnableCallQueueWhenNoAgentsAvailable { get; set; }
    [XmlElement(ElementName = "statisticsSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSource StatisticsSource { get; set; }
 }
}
