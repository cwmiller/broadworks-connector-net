using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPortalPasscodeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _oldPasscode;

    [XmlElement(ElementName = "oldPasscode", IsNullable = false, Namespace = "")]
    public string OldPasscode {
        get => _oldPasscode;
        set {
            OldPasscodeSpecified = true;
            _oldPasscode = value;
        }
    }

    [XmlIgnore]
    public bool OldPasscodeSpecified { get; set; }
    private string _newPasscode;

    [XmlElement(ElementName = "newPasscode", IsNullable = false, Namespace = "")]
    public string NewPasscode {
        get => _newPasscode;
        set {
            NewPasscodeSpecified = true;
            _newPasscode = value;
        }
    }

    [XmlIgnore]
    public bool NewPasscodeSpecified { get; set; }
}
}
