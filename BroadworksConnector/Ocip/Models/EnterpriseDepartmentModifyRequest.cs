using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseDepartmentModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enterpriseId", IsNullable = false)]
    public string EnterpriseId { get; set; }
    [XmlElement(ElementName = "departmentName", IsNullable = false)]
    public string DepartmentName { get; set; }
    [XmlElement(ElementName = "newDepartmentName", IsNullable = false)]
    public string NewDepartmentName { get; set; }
    [XmlElement(ElementName = "newParentDepartmentKey", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.EnterpriseDepartmentKey NewParentDepartmentKey { get; set; }
 }
}
