using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentAdminGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "departmentAdminTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DepartmentAdminTable { get; set; }
 }
}
