using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetRouteDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _routeDeviceTable;

    [XmlElement(ElementName = "routeDeviceTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RouteDeviceTable {
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
