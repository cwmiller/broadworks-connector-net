using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutingProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _routingProfile;

    [XmlElement(ElementName = "routingProfile", IsNullable = false, Namespace = "")]
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
