using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserShInterfaceGetPublicIdDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PublicUserIdentity PublicUserIdentity {
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
