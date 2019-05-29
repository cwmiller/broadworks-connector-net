using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterGetResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false)]
    public string DefaultFromAddress { get; set; }
    [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes { get; set; }
    [XmlElement(ElementName = "defaultEnableGuardTimer", IsNullable = false)]
    public bool DefaultEnableGuardTimer { get; set; }
    [XmlElement(ElementName = "defaultGuardTimerSeconds", IsNullable = false)]
    public int DefaultGuardTimerSeconds { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false)]
    public bool ForceAgentUnavailableOnDNDActivation { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false)]
    public bool ForceAgentUnavailableOnPersonalCalls { get; set; }
    [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false)]
    public bool ForceAgentUnavailableOnBouncedCallLimit { get; set; }
    [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false)]
    public int NumberConsecutiveBouncedCallsToForceAgentUnavailable { get; set; }
 }
}
