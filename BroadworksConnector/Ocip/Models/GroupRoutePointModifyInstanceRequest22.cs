using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyInstanceRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec22 ExternalPreferredAudioCodec { get; set; }
    [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec22 InternalPreferredAudioCodec { get; set; }
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
    [XmlElement(ElementName = "wrapUpSeconds", IsNullable = true)]
    public int? WrapUpSeconds { get; set; }
    [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false)]
    public bool EnableAutomaticStateChangeForAgents { get; set; }
    [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AgentACDAutomaticState AgentStateAfterCall { get; set; }
    [XmlElement(ElementName = "agentUnavailableCode", IsNullable = true)]
    public string AgentUnavailableCode { get; set; }
    [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false)]
    public bool ForceDeliveryOfCalls { get; set; }
    [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = true)]
    public int? ForceDeliveryWaitTimeSeconds { get; set; }
 }
}
