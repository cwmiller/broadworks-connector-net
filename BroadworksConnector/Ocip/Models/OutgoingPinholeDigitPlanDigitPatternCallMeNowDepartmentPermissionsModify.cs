using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternCallMeNowDepartmentPermissionsModify 
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
    private BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermissions _digitPatternPermissions;

    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermissions DigitPatternPermissions {
        get => _digitPatternPermissions;
        set {
            DigitPatternPermissionsSpecified = true;
            _digitPatternPermissions = value;
        }
    }

    [XmlIgnore]
    public bool DigitPatternPermissionsSpecified { get; set; }
}
}
