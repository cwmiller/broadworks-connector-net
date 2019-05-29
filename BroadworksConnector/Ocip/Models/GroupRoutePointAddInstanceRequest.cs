using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec ExternalPreferredAudioCodec { get; set; }
    [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec InternalPreferredAudioCodec { get; set; }
    [XmlElement(ElementName = "queueLength", IsNullable = false)]
    public int QueueLength { get; set; }
    [XmlElement(ElementName = "noAnswerTimeoutRings", IsNullable = false)]
    public int NoAnswerTimeoutRings { get; set; }
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false)]
    public bool PlayRingingWhenOfferingCall { get; set; }
    [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false)]
    public bool OverrideAgentWrapUpTime { get; set; }
    [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false)]
    public int WrapUpSeconds { get; set; }
    [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false)]
    public bool EnableAutomaticStateChangeForAgents { get; set; }
    [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AgentACDAutomaticState AgentStateAfterCall { get; set; }
    [XmlElement(ElementName = "agentUnavailableCode", IsNullable = false)]
    public string AgentUnavailableCode { get; set; }
    [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false)]
    public bool ForceDeliveryOfCalls { get; set; }
    [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = false)]
    public int ForceDeliveryWaitTimeSeconds { get; set; }
 }
}
