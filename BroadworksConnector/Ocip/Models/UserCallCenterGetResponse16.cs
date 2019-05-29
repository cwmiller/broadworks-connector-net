using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterGetResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "agentACDState", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AgentACDState AgentACDState { get; set; }
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
    [XmlElement(ElementName = "forceUnavailableOnPersonalCalls", IsNullable = false)]
    public bool ForceUnavailableOnPersonalCalls { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false)]
    public bool ForceAgentUnavailableOnBouncedCallLimit { get; set; }
    [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false)]
    public int NumberConsecutiveBouncedCallsToForceAgentUnavailable { get; set; }
    [XmlElement(ElementName = "callCenterTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallCenterTable { get; set; }
 }
}
