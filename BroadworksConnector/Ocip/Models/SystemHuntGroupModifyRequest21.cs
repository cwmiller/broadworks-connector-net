using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHuntGroupModifyRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false)]
    public bool RemoveHuntGroupNameFromCLID { get; set; }
    [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HuntGroupUniformCallDistributionPolicyScope UniformCallDistributionPolicyScope { get; set; }
    [XmlElement(ElementName = "allowAgentDeviceInitiatedForward", IsNullable = false)]
    public bool AllowAgentDeviceInitiatedForward { get; set; }
 }
}
