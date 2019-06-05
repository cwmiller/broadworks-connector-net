using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetRouteListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _routeName;

    [XmlElement(ElementName = "routeName", IsNullable = false, Namespace = "")]
    public List<string> RouteName {
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
