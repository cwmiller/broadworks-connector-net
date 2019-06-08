using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkAddressingMultipleContactRead 
{
    private BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead _trunkGroupDeviceEndpoint;

    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead TrunkGroupDeviceEndpoint {
        get => _trunkGroupDeviceEndpoint;
        set {
            TrunkGroupDeviceEndpointSpecified = true;
            _trunkGroupDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupDeviceEndpointSpecified { get; set; }
    private string _enterpriseTrunkName;

    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
    public string EnterpriseTrunkName {
        get => _enterpriseTrunkName;
        set {
            EnterpriseTrunkNameSpecified = true;
            _enterpriseTrunkName = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseTrunkNameSpecified { get; set; }
    private string _alternateTrunkIdentity;

    [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = false, Namespace = "")]
    public string AlternateTrunkIdentity {
        get => _alternateTrunkIdentity;
        set {
            AlternateTrunkIdentitySpecified = true;
            _alternateTrunkIdentity = value;
        }
    }

    [XmlIgnore]
    public bool AlternateTrunkIdentitySpecified { get; set; }
}
}
