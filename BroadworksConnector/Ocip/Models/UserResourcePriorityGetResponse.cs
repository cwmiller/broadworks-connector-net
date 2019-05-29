using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserResourcePriorityGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false)]
    public bool UseDefaultResourcePriority { get; set; }
    [XmlElement(ElementName = "defaultResourcePriority", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResourcePriorityValue DefaultResourcePriority { get; set; }
    [XmlElement(ElementName = "userResourcePriority", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResourcePriorityValue UserResourcePriority { get; set; }
 }
}
