using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserShInterfaceGetPublicIdDataRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.PublicUserIdentity PublicUserIdentity {
        get => _publicUserIdentity;
        set {
            PublicUserIdentitySpecified = true;
            _publicUserIdentity = value;
        }
    }

    [XmlIgnore]
    public bool PublicUserIdentitySpecified { get; set; }
}
}
