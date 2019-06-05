using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LoginRequest13mp10 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
}
}
