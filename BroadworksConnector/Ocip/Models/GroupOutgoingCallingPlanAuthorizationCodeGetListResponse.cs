using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanAuthorizationCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes _groupCodeList;

    [XmlElement(ElementName = "groupCodeList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanGroupAuthorizationCodes GroupCodeList {
        get => _groupCodeList;
        set {
            GroupCodeListSpecified = true;
            _groupCodeList = value;
        }
    }

    [XmlIgnore]
    public bool GroupCodeListSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> _departmentCodeList;

    [XmlElement(ElementName = "departmentCodeList", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDepartmentAuthorizationCodes> DepartmentCodeList {
        get => _departmentCodeList;
        set {
            DepartmentCodeListSpecified = true;
            _departmentCodeList = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentCodeListSpecified { get; set; }
}
}
