using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAuthenticationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _userName;

    [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
    public string UserName {
        get => _userName;
        set {
            UserNameSpecified = true;
            _userName = value;
        }
    }

    [XmlIgnore]
    public bool UserNameSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.UserAuthenticationModifyRequestPassword _password;

    [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserAuthenticationModifyRequestPassword Password {
        get => _password;
        set {
            PasswordSpecified = true;
            _password = value;
        }
    }

    [XmlIgnore]
    public bool PasswordSpecified { get; set; }
}
}
