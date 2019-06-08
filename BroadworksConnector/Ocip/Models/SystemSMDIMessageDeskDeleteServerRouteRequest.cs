using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskDeleteServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _routeDestination;

    [XmlElement(ElementName = "routeDestination", IsNullable = false, Namespace = "")]
    public string RouteDestination {
        get => _routeDestination;
        set {
            RouteDestinationSpecified = true;
            _routeDestination = value;
        }
    }

    [XmlIgnore]
    public bool RouteDestinationSpecified { get; set; }
}
}
