using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "groupPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermissions GroupPermissions { get; set; }
    [XmlElement(ElementName = "departmentPermissions", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowDepartmentPermissionsModify> DepartmentPermissions { get; set; }
 }
}
