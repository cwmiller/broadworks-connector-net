using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHPBXMobileTerminationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _routingPrefix;

    [XmlElement(ElementName = "routingPrefix", IsNullable = true, Namespace = "")]
    public string RoutingPrefix {
        get => _routingPrefix;
        set {
            RoutingPrefixSpecified = true;
            _routingPrefix = value;
        }
    }

    [XmlIgnore]
    public bool RoutingPrefixSpecified { get; set; }
}
}
