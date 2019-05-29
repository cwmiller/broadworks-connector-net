using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterAgentUnavailableCodeSettingsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableAgentUnavailableCodes", IsNullable = false)]
    public bool EnableAgentUnavailableCodes { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCodeOnDND", IsNullable = false)]
    public string DefaultAgentUnavailableCodeOnDND { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCodeOnPersonalCalls", IsNullable = false)]
    public string DefaultAgentUnavailableCodeOnPersonalCalls { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCodeOnConsecutiveBounces", IsNullable = false)]
    public string DefaultAgentUnavailableCodeOnConsecutiveBounces { get; set; }
    [XmlElement(ElementName = "forceUseOfAgentUnavailableCodes", IsNullable = false)]
    public bool ForceUseOfAgentUnavailableCodes { get; set; }
    [XmlElement(ElementName = "defaultAgentUnavailableCode", IsNullable = false)]
    public string DefaultAgentUnavailableCode { get; set; }
 }
}
