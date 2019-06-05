using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanCallMeNowDepartmentPermissionsModify 
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
    private BroadworksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissionsModify _permissions;

    [XmlElement(ElementName = "permissions", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissionsModify Permissions {
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
