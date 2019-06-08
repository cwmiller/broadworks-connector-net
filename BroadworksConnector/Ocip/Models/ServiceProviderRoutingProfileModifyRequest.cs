using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderRoutingProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _routingProfile;

    [XmlElement(ElementName = "routingProfile", IsNullable = true, Namespace = "")]
    public string RoutingProfile {
        get => _routingProfile;
        set {
            RoutingProfileSpecified = true;
            _routingProfile = value;
        }
    }

    [XmlIgnore]
    public bool RoutingProfileSpecified { get; set; }
}
}
