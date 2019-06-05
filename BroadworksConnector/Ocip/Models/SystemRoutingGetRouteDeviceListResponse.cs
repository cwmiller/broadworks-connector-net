using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetRouteDeviceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _routeDeviceTable;

    [XmlElement(ElementName = "routeDeviceTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RouteDeviceTable {
        get => _routeDeviceTable;
        set {
            RouteDeviceTableSpecified = true;
            _routeDeviceTable = value;
        }
    }

    [XmlIgnore]
    public bool RouteDeviceTableSpecified { get; set; }
}
}
