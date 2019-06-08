using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeCostInformationSourceDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _peerIdentity;

    [XmlElement(ElementName = "peerIdentity", IsNullable = false, Namespace = "")]
    public string PeerIdentity {
        get => _peerIdentity;
        set {
            PeerIdentitySpecified = true;
            _peerIdentity = value;
        }
    }

    [XmlIgnore]
    public bool PeerIdentitySpecified { get; set; }
}
}
