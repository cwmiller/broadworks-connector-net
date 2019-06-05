using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyRequest22Endpoint 
{
    private BroadworksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify22 _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify22 AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactModify22 _trunkAddressing;

    [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactModify22 TrunkAddressing {
        get => _trunkAddressing;
        set {
            TrunkAddressingSpecified = true;
            _trunkAddressing = value;
        }
    }

    [XmlIgnore]
    public bool TrunkAddressingSpecified { get; set; }
}
}
