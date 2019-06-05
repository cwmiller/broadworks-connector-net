using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDnDepartment : BroadworksConnector.Ocip.Models.SearchCriteria
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
}
}
