using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentAdminGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _departmentAdminTable;

    [XmlElement(ElementName = "departmentAdminTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DepartmentAdminTable {
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
