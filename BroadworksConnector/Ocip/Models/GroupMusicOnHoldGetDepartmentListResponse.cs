using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMusicOnHoldGetDepartmentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _hasDepartment;

    [XmlElement(ElementName = "hasDepartment", IsNullable = false, Namespace = "")]
    public bool HasDepartment {
        get => _hasDepartment;
        set {
            HasDepartmentSpecified = true;
            _hasDepartment = value;
        }
    }

    [XmlIgnore]
    public bool HasDepartmentSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.DepartmentKey> _department;

    [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.DepartmentKey> Department {
        get => _department;
        set {
            DepartmentSpecified = true;
            _department = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentSpecified { get; set; }
    private List<string> _departmentFullPath;

    [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
    public List<string> DepartmentFullPath {
        get => _departmentFullPath;
        set {
            DepartmentFullPathSpecified = true;
            _departmentFullPath = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentFullPathSpecified { get; set; }
}
}
