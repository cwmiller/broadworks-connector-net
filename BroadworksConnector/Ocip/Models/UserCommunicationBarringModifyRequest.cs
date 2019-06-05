using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommunicationBarringModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _useGroupSetting;

    [XmlElement(ElementName = "useGroupSetting", IsNullable = false, Namespace = "")]
    public bool UseGroupSetting {
        get => _useGroupSetting;
        set {
            UseGroupSettingSpecified = true;
            _useGroupSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupSettingSpecified { get; set; }
    private string _profileName;

    [XmlElement(ElementName = "profileName", IsNullable = true, Namespace = "")]
    public string ProfileName {
        get => _profileName;
        set {
            ProfileNameSpecified = true;
            _profileName = value;
        }
    }

    [XmlIgnore]
    public bool ProfileNameSpecified { get; set; }
}
}
