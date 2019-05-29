using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseDepartmentAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enterpriseId", IsNullable = false)]
    public string EnterpriseId { get; set; }
    [XmlElement(ElementName = "departmentName", IsNullable = false)]
    public string DepartmentName { get; set; }
    [XmlElement(ElementName = "parentDepartmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseDepartmentKey ParentDepartmentKey { get; set; }
 }
}
