using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingPermissions _groupPermissions;

    [XmlElement(ElementName = "groupPermissions", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingPermissions GroupPermissions {
        get => _groupPermissions;
        set {
            GroupPermissionsSpecified = true;
            _groupPermissions = value;
        }
    }

    [XmlIgnore]
    public bool GroupPermissionsSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingDepartmentPermissions> _departmentPermissions;

    [XmlElement(ElementName = "departmentPermissions", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingDepartmentPermissions> DepartmentPermissions {
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
