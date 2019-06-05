using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdminGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _systemAdminTable;

    [XmlElement(ElementName = "systemAdminTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SystemAdminTable {
        get => _systemAdminTable;
        set {
            SystemAdminTableSpecified = true;
            _systemAdminTable = value;
        }
    }

    [XmlIgnore]
    public bool SystemAdminTableSpecified { get; set; }
}
}
