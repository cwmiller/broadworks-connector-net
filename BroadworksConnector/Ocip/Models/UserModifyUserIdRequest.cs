using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyUserIdRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _newUserId;

    [XmlElement(ElementName = "newUserId", IsNullable = false, Namespace = "")]
    public string NewUserId {
        get => _newUserId;
        set {
            NewUserIdSpecified = true;
            _newUserId = value;
        }
    }

    [XmlIgnore]
    public bool NewUserIdSpecified { get; set; }
}
}
