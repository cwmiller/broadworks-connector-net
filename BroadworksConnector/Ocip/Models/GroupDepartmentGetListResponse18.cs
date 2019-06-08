using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentGetListResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _departmentTable;

    [XmlElement(ElementName = "departmentTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DepartmentTable {
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
