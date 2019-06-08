using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointExternalSystemGetAssignedRoutePointListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _routePointTable;

    [XmlElement(ElementName = "routePointTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RoutePointTable {
        get => _routePointTable;
        set {
            RoutePointTableSpecified = true;
            _routePointTable = value;
        }
    }

    [XmlIgnore]
    public bool RoutePointTableSpecified { get; set; }
}
}
