using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExternalAuthenticationAuthorizeTokenRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _password;

    [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
    public string Password {
        get => _password;
        set {
            PasswordSpecified = true;
            _password = value;
        }
    }

    [XmlIgnore]
    public bool PasswordSpecified { get; set; }
    private bool _isPasswordHashed;

    [XmlElement(ElementName = "isPasswordHashed", IsNullable = false, Namespace = "")]
    public bool IsPasswordHashed {
        get => _isPasswordHashed;
        set {
            IsPasswordHashedSpecified = true;
            _isPasswordHashed = value;
        }
    }

    [XmlIgnore]
    public bool IsPasswordHashedSpecified { get; set; }
    private string _loginToken;

    [XmlElement(ElementName = "loginToken", IsNullable = false, Namespace = "")]
    public string LoginToken {
        get => _loginToken;
        set {
            LoginTokenSpecified = true;
            _loginToken = value;
        }
    }

    [XmlIgnore]
    public bool LoginTokenSpecified { get; set; }
}
}
