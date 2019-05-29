using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanCallMeNowGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissions GroupPermissions { get; set; }
    [XmlElement(ElementName = "departmentPermissions", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowDepartmentPermissions> DepartmentPermissions { get; set; }
 }
}
