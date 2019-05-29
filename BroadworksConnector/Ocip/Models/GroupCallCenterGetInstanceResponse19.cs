using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetInstanceResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterType Type { get; set; }
    [XmlElement(ElementName = "routingType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterRoutingType RoutingType { get; set; }
    [XmlElement(ElementName = "policy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HuntPolicy Policy { get; set; }
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "queueLength", IsNullable = false)]
    public int QueueLength { get; set; }
    [XmlElement(ElementName = "enableReporting", IsNullable = false)]
    public bool EnableReporting { get; set; }
    [XmlElement(ElementName = "allowCallerToDialEscapeDigit", IsNullable = false)]
    public bool AllowCallerToDialEscapeDigit { get; set; }
    [XmlElement(ElementName = "escapeDigit", IsNullable = false)]
    public string EscapeDigit { get; set; }
    [XmlElement(ElementName = "resetCallStatisticsUponEntryInQueue", IsNullable = false)]
    public bool ResetCallStatisticsUponEntryInQueue { get; set; }
    [XmlElement(ElementName = "allowAgentLogoff", IsNullable = false)]
    public bool AllowAgentLogoff { get; set; }
    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false)]
    public bool AllowCallWaitingForAgents { get; set; }
    [XmlElement(ElementName = "allowCallsToAgentsInWrapUp", IsNullable = false)]
    public bool AllowCallsToAgentsInWrapUp { get; set; }
    [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false)]
    public bool OverrideAgentWrapUpTime { get; set; }
    [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false)]
    public int WrapUpSeconds { get; set; }
    [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false)]
    public bool ForceDeliveryOfCalls { get; set; }
    [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = false)]
    public int ForceDeliveryWaitTimeSeconds { get; set; }
    [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false)]
    public bool EnableAutomaticStateChangeForAgents { get; set; }
    [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AgentACDAutomaticState AgentStateAfterCall { get; set; }
    [XmlElement(ElementName = "agentUnavailableCode", IsNullable = false)]
    public string AgentUnavailableCode { get; set; }
    [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec ExternalPreferredAudioCodec { get; set; }
    [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec InternalPreferredAudioCodec { get; set; }
    [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false)]
    public bool PlayRingingWhenOfferingCall { get; set; }
    [XmlElement(ElementName = "callCenterQueueThresholdsIsActive", IsNullable = false)]
    public bool CallCenterQueueThresholdsIsActive { get; set; }
 }
}
