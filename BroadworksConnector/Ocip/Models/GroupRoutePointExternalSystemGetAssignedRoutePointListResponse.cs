using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointExternalSystemGetAssignedRoutePointListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _routePointTable;

    [XmlElement(ElementName = "routePointTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutePointTable {
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
