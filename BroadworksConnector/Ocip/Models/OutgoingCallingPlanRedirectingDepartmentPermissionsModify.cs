using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanRedirectingDepartmentPermissionsModify 
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey DepartmentKey { get; set; }
    [XmlElement(ElementName = "permissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanRedirectingPermissionsModify Permissions { get; set; }
 }
}
