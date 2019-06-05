using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions _groupPermissions;

    [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions GroupPermissions {
        get => _groupPermissions;
        set {
            GroupPermissionsSpecified = true;
            _groupPermissions = value;
        }
    }

    [XmlIgnore]
    public bool GroupPermissionsSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingDepartmentPermissions> _departmentPermissions;

    [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingDepartmentPermissions> DepartmentPermissions {
        get => _departmentPermissions;
        set {
            DepartmentPermissionsSpecified = true;
            _departmentPermissions = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentPermissionsSpecified { get; set; }
}
}
