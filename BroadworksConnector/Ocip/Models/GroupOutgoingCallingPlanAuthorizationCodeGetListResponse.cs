using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanAuthorizationCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupCodeList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes GroupCodeList { get; set; }
    [XmlElement(ElementName = "departmentCodeList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> DepartmentCodeList { get; set; }
 }
}
