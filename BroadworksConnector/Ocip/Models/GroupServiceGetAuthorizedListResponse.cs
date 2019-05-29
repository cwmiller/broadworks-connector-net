using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceGetAuthorizedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public List<string> ServicePackName { get; set; }
    [XmlElement(ElementName = "groupServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupService> GroupServiceName { get; set; }
    [XmlElement(ElementName = "userServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> UserServiceName { get; set; }
 }
}
