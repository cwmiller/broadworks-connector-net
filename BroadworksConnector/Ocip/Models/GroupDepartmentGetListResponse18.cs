using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentGetListResponse18 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _departmentTable;

    [XmlElement(ElementName = "departmentTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DepartmentTable {
        get => _departmentTable;
        set {
            DepartmentTableSpecified = true;
            _departmentTable = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentTableSpecified { get; set; }
}
}
