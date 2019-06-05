using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyRequest14Endpoint 
{
    private BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointModify _trunkGroupDeviceEndpoint;

    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointModify TrunkGroupDeviceEndpoint {
        get => _trunkGroupDeviceEndpoint;
        set {
            TrunkGroupDeviceEndpointSpecified = true;
            _trunkGroupDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupDeviceEndpointSpecified { get; set; }
}
}
