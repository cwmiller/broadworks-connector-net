using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRoutePointSupervisorGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _supervisorTable;

    [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SupervisorTable {
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
