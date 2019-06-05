using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTerminatingAlternateTrunkIdentityModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _terminatingTrunkIdentity;

    [XmlElement(ElementName = "terminatingTrunkIdentity", IsNullable = true, Namespace = "")]
    public string TerminatingTrunkIdentity {
        get => _terminatingTrunkIdentity;
        set {
            TerminatingTrunkIdentitySpecified = true;
            _terminatingTrunkIdentity = value;
        }
    }

    [XmlIgnore]
    public bool TerminatingTrunkIdentitySpecified { get; set; }
}
}
