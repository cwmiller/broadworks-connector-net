using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterAgentUnavailableCodeSettingsModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "enableAgentUnavailableCodes", IsNullable = false)]
    public bool EnableAgentUnavailableCodes { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCodeOnDND", IsNullable = true)]
    public string DefaultAgentUnavailableCodeOnDND { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCodeOnPersonalCalls", IsNullable = true)]
    public string DefaultAgentUnavailableCodeOnPersonalCalls { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCodeOnConsecutiveBounces", IsNullable = true)]
    public string DefaultAgentUnavailableCodeOnConsecutiveBounces { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCodeOnNotReachable", IsNullable = true)]
    public string DefaultAgentUnavailableCodeOnNotReachable { get; set; }
    [XmlElement(ElementName = "forceUseOfAgentUnavailableCodes", IsNullable = false)]
    public bool ForceUseOfAgentUnavailableCodes { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCode", IsNullable = true)]
    public string DefaultAgentUnavailableCode { get; set; }
    [XmlElement(ElementName = "codeStateList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCenterAgentUnavailableCodeStateModify> CodeStateList { get; set; }
 }
}
