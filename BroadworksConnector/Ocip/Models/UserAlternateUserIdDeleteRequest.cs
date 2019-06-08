using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateUserIdDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _alternateUserId;

    [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
    public string AlternateUserId {
        get => _alternateUserId;
        set {
            AlternateUserIdSpecified = true;
            _alternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool AlternateUserIdSpecified { get; set; }
}
}
