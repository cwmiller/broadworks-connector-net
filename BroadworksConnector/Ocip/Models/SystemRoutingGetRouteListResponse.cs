using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetRouteListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
