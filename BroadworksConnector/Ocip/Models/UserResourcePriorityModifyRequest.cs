using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserResourcePriorityModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false)]
    public bool UseDefaultResourcePriority { get; set; }
    [XmlElement(ElementName = "userResourcePriority", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResourcePriorityValue UserResourcePriority { get; set; }
 }
}
