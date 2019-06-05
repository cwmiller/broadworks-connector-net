using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserConsolidatedModifyRequestEndpoint 
{
    private BroadworksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactModify _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactModify AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactModify _trunkAddressing;

    [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactModify TrunkAddressing {
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
