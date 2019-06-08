using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LoginRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _signedPassword;

    [XmlElement(ElementName = "signedPassword", IsNullable = false, Namespace = "")]
    public string SignedPassword {
        get => _signedPassword;
        set {
            SignedPasswordSpecified = true;
            _signedPassword = value;
        }
    }

    [XmlIgnore]
    public bool SignedPasswordSpecified { get; set; }
    private string _plainTextPassword;

    [XmlElement(ElementName = "plainTextPassword", IsNullable = false, Namespace = "")]
    public string PlainTextPassword {
        get => _plainTextPassword;
        set {
            PlainTextPasswordSpecified = true;
            _plainTextPassword = value;
        }
    }

    [XmlIgnore]
    public bool PlainTextPasswordSpecified { get; set; }
}
}
