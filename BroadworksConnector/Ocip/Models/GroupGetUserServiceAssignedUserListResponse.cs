using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetUserServiceAssignedUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userListTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserListTable { get; set; }
 }
}
