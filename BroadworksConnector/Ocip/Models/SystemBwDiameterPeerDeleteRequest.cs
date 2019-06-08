using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterPeerDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
