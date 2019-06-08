using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingRealmDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

    [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance Instance {
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
    private BroadWorksConnector.Ocip.Models.BwDiameterApplicationId _applicationId;

    [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.BwDiameterApplicationId ApplicationId {
        get => _applicationId;
        set {
            ApplicationIdSpecified = true;
            _applicationId = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationIdSpecified { get; set; }
}
}
