using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _systemAdminTable;

    [XmlElement(ElementName = "systemAdminTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SystemAdminTable {
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
