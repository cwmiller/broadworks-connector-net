using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMigratedUsersGetListRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userListSizeLimit", IsNullable = false)]
    public int UserListSizeLimit { get; set; }
 }
}
