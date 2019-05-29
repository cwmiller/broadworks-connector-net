using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMigratedUsersGetListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public List<string> UserId { get; set; }
    [XmlElement(ElementName = "totalNumberOfMigratedUsers", IsNullable = false)]
    public int TotalNumberOfMigratedUsers { get; set; }
 }
}
