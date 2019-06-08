using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingPeerAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private int _priority;

    [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
    public int Priority {
        get => _priority;
        set {
            PrioritySpecified = true;
            _priority = value;
        }
    }

    [XmlIgnore]
    public bool PrioritySpecified { get; set; }
    private int _weight;

    [XmlElement(ElementName = "weight", IsNullable = false, Namespace = "")]
    public int Weight {
        get => _weight;
        set {
            WeightSpecified = true;
            _weight = value;
        }
    }

    [XmlIgnore]
    public bool WeightSpecified { get; set; }
}
}
