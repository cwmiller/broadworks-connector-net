using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternRedirectingDepartmentPermissions 
{
    private BroadworksConnector.Ocip.Models.DepartmentKey _departmentKey;

    [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DepartmentKey DepartmentKey {
        get => _departmentKey;
        set {
            DepartmentKeySpecified = true;
            _departmentKey = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentKeySpecified { get; set; }
    private string _departmentName;

    [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
    public string DepartmentName {
        get => _departmentName;
        set {
            DepartmentNameSpecified = true;
            _departmentName = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions _permissions;

    [XmlElement(ElementName = "permissions", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions Permissions {
        get => _permissions;
        set {
            PermissionsSpecified = true;
            _permissions = value;
        }
    }

    [XmlIgnore]
    public bool PermissionsSpecified { get; set; }
}
}
