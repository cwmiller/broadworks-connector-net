using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldGetDepartmentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "hasDepartment", IsNullable = false)]
    public bool HasDepartment { get; set; }
    [XmlElement(ElementName = "department", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DepartmentKey> Department { get; set; }
    [XmlElement(ElementName = "departmentFullPath", IsNullable = false)]
    public List<string> DepartmentFullPath { get; set; }
 }
}
