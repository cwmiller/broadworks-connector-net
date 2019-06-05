using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkAddressingMultipleContactModify22 
{
    private BroadworksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointModify22 _trunkGroupDeviceEndpoint;

    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointModify22 TrunkGroupDeviceEndpoint {
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
    private string _alternateTrunkIdentityDomain;

    [XmlElement(ElementName = "alternateTrunkIdentityDomain", IsNullable = true, Namespace = "")]
    public string AlternateTrunkIdentityDomain {
        get => _alternateTrunkIdentityDomain;
        set {
            AlternateTrunkIdentityDomainSpecified = true;
            _alternateTrunkIdentityDomain = value;
        }
    }

    [XmlIgnore]
    public bool AlternateTrunkIdentityDomainSpecified { get; set; }
    private string _physicalLocation;

    [XmlElement(ElementName = "physicalLocation", IsNullable = true, Namespace = "")]
    public string PhysicalLocation {
        get => _physicalLocation;
        set {
            PhysicalLocationSpecified = true;
            _physicalLocation = value;
        }
    }

    [XmlIgnore]
    public bool PhysicalLocationSpecified { get; set; }
}
}
