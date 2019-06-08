using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _oldPassword;

    [XmlElement(ElementName = "oldPassword", IsNullable = false, Namespace = "")]
    public string OldPassword {
        get => _oldPassword;
        set {
            OldPasswordSpecified = true;
            _oldPassword = value;
        }
    }

    [XmlIgnore]
    public bool OldPasswordSpecified { get; set; }
    private string _newPassword;

    [XmlElement(ElementName = "newPassword", IsNullable = false, Namespace = "")]
    public string NewPassword {
        get => _newPassword;
        set {
            NewPasswordSpecified = true;
            _newPassword = value;
        }
    }

    [XmlIgnore]
    public bool NewPasswordSpecified { get; set; }
}
}
