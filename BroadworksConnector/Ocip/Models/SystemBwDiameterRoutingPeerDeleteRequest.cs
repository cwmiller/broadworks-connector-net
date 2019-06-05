using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingPeerDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

    [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.BwDiameterPeerInstance Instance {
        get => _instance;
        set {
            InstanceSpecified = true;
            _instance = value;
        }
    }

    [XmlIgnore]
    public bool InstanceSpecified { get; set; }
    private string _realm;

    [XmlElement(ElementName = "realm", IsNullable = false, Namespace = "")]
    public string Realm {
        get => _realm;
        set {
            RealmSpecified = true;
            _realm = value;
        }
    }

    [XmlIgnore]
    public bool RealmSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.BwDiameterApplicationId _applicationId;

    [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.BwDiameterApplicationId ApplicationId {
        get => _applicationId;
        set {
            ApplicationIdSpecified = true;
            _applicationId = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationIdSpecified { get; set; }
    private string _identity;

    [XmlElement(ElementName = "identity", IsNullable = false, Namespace = "")]
    public string Identity {
        get => _identity;
        set {
            IdentitySpecified = true;
            _identity = value;
        }
    }

    [XmlIgnore]
    public bool IdentitySpecified { get; set; }
}
}
