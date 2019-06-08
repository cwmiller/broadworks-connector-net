using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _departmentAdminTable;

    [XmlElement(ElementName = "departmentAdminTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DepartmentAdminTable {
        get => _departmentAdminTable;
        set {
            DepartmentAdminTableSpecified = true;
            _departmentAdminTable = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAdminTableSpecified { get; set; }
}
}
