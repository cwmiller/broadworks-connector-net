using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseDepartmentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.DepartmentKey> _departmentKey;

    [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.DepartmentKey> DepartmentKey {
        get => _departmentKey;
        set {
            DepartmentKeySpecified = true;
            _departmentKey = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentKeySpecified { get; set; }
    private List<string> _fullPathName;

    [XmlElement(ElementName = "fullPathName", IsNullable = false, Namespace = "")]
    public List<string> FullPathName {
        get => _fullPathName;
        set {
            FullPathNameSpecified = true;
            _fullPathName = value;
        }
    }

    [XmlIgnore]
    public bool FullPathNameSpecified { get; set; }
}
}
