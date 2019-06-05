using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkAddressingModify 
{
    private BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointModify _trunkGroupDeviceEndpoint;

    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointModify TrunkGroupDeviceEndpoint {
        get => _trunkGroupDeviceEndpoint;
        set {
            TrunkGroupDeviceEndpointSpecified = true;
            _trunkGroupDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupDeviceEndpointSpecified { get; set; }
    private string _enterpriseTrunkName;

    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = true, Namespace = "")]
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
