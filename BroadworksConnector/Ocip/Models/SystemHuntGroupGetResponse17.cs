using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHuntGroupGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "anonymousInsteadOfPrivateCLID", IsNullable = false)]
    public bool AnonymousInsteadOfPrivateCLID { get; set; }
    [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false)]
    public bool RemoveHuntGroupNameFromCLID { get; set; }
    [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HuntGroupUniformCallDistributionPolicyScope UniformCallDistributionPolicyScope { get; set; }
 }
}
