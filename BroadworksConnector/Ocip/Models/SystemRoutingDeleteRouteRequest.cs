using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingDeleteRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _routeName;

    [XmlElement(ElementName = "routeName", IsNullable = false, Namespace = "")]
    public string RouteName {
        get => _routeName;
        set {
            RouteNameSpecified = true;
            _routeName = value;
        }
    }

    [XmlIgnore]
    public bool RouteNameSpecified { get; set; }
}
}
