using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AssignedGroupServicesEntry 
{
    [XmlElement(ElementName = "serviceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupService ServiceName { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
 }
}
