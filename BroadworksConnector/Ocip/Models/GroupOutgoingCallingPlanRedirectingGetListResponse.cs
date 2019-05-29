using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanRedirectingGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanRedirectingPermissions GroupPermissions { get; set; }
    [XmlElement(ElementName = "departmentPermissions", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanRedirectingDepartmentPermissions> DepartmentPermissions { get; set; }
 }
}
