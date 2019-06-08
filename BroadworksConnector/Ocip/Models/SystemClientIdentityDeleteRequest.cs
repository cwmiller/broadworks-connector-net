using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClientIdentityDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _clientIdentity;

    [XmlElement(ElementName = "clientIdentity", IsNullable = false, Namespace = "")]
    public string ClientIdentity {
        get => _clientIdentity;
        set {
            ClientIdentitySpecified = true;
            _clientIdentity = value;
        }
    }

    [XmlIgnore]
    public bool ClientIdentitySpecified { get; set; }
}
}
