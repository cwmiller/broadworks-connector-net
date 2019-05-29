using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentGetListResponse18 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "departmentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DepartmentTable { get; set; }
 }
}
