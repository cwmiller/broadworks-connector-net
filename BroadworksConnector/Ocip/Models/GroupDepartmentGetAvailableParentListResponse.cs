using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentGetAvailableParentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DepartmentKey> DepartmentKey { get; set; }
    [XmlElement(ElementName = "fullPathName", IsNullable = false)]
    public List<string> FullPathName { get; set; }
 }
}
