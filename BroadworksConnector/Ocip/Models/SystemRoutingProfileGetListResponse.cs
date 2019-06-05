using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingProfileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _routingProfile;

    [XmlElement(ElementName = "routingProfile", IsNullable = false, Namespace = "")]
    public List<string> RoutingProfile {
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
