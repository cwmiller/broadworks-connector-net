using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanCallMeNowDepartmentPermissionsModify 
{
    private BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

    [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DepartmentKey DepartmentKey {
        get => _departmentKey;
        set {
            DepartmentKeySpecified = true;
            _departmentKey = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentKeySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissionsModify _permissions;

    [XmlElement(ElementName = "permissions", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanCallMeNowPermissionsModify Permissions {
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
