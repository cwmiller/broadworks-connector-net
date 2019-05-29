using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useSystemDefaultGuardTimer", IsNullable = false)]
    public bool UseSystemDefaultGuardTimer { get; set; }
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
 }
}
