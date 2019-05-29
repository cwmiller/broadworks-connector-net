using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanRedirectedDepartmentPermissionsModify 
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey DepartmentKey { get; set; }
    [XmlElement(ElementName = "permissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanRedirectedPermissionsModify Permissions { get; set; }
 }
}
