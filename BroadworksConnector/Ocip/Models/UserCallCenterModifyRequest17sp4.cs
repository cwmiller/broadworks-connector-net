using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterModifyRequest17sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "agentACDState", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AgentACDState AgentACDState { get; set; }
    [XmlElement(ElementName = "agentThresholdProfileName", IsNullable = false)]
    public string AgentThresholdProfileName { get; set; }
    [XmlElement(ElementName = "agentUnavailableCode", IsNullable = true)]
    public string AgentUnavailableCode { get; set; }
    [XmlElement(ElementName = "useDefaultGuardTimer", IsNullable = false)]
    public bool UseDefaultGuardTimer { get; set; }
    [XmlElement(ElementName = "enableGuardTimer", IsNullable = false)]
    public bool EnableGuardTimer { get; set; }
    [XmlElement(ElementName = "guardTimerSeconds", IsNullable = false)]
    public int GuardTimerSeconds { get; set; }
    [XmlElement(ElementName = "useSystemDefaultUnavailableSettings", IsNullable = false)]
    public bool UseSystemDefaultUnavailableSettings { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false)]
    public bool ForceAgentUnavailableOnDNDActivation { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false)]
    public bool ForceAgentUnavailableOnPersonalCalls { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false)]
    public bool ForceAgentUnavailableOnBouncedCallLimit { get; set; }
    [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false)]
    public int NumberConsecutiveBouncedCallsToForceAgentUnavailable { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnNotReachable", IsNullable = false)]
    public bool ForceAgentUnavailableOnNotReachable { get; set; }
    [XmlElement(ElementName = "makeOutgoingCallsAsCallCenter", IsNullable = false)]
    public bool MakeOutgoingCallsAsCallCenter { get; set; }
    [XmlElement(ElementName = "outgoingCallDNIS", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DNISKey OutgoingCallDNIS { get; set; }
    [XmlElement(ElementName = "callCenterAvailability", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCenterAgentAvailability> CallCenterAvailability { get; set; }
 }
}
