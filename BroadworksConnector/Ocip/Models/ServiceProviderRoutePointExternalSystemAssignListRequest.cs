using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderRoutePointExternalSystemAssignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private List<string> _routePointExternalSystem;

    [XmlElement(ElementName = "routePointExternalSystem", IsNullable = false, Namespace = "")]
    public List<string> RoutePointExternalSystem {
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
