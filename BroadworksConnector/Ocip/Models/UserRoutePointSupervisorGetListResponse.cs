using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRoutePointSupervisorGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _supervisorTable;

    [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SupervisorTable {
        get => _supervisorTable;
        set {
            SupervisorTableSpecified = true;
            _supervisorTable = value;
        }
    }

    [XmlIgnore]
    public bool SupervisorTableSpecified { get; set; }
}
}
