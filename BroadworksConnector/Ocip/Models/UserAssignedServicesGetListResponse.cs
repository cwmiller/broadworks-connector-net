using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAssignedServicesGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupServiceEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AssignedGroupServicesEntry> GroupServiceEntry { get; set; }
    [XmlElement(ElementName = "userServiceEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AssignedUserServicesEntry> UserServiceEntry { get; set; }
 }
}
