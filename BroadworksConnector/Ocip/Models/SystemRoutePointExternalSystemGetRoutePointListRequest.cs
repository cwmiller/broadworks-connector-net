using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutePointExternalSystemGetRoutePointListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _routePointExternalSystem;

    [XmlElement(ElementName = "routePointExternalSystem", IsNullable = false, Namespace = "")]
    public string RoutePointExternalSystem {
        get => _routePointExternalSystem;
        set {
            RoutePointExternalSystemSpecified = true;
            _routePointExternalSystem = value;
        }
    }

    [XmlIgnore]
    public bool RoutePointExternalSystemSpecified { get; set; }
}
}
