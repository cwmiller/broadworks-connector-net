using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanTransferNumbersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _useCustomSettings;

    [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
    public bool UseCustomSettings {
        get => _useCustomSettings;
        set {
            UseCustomSettingsSpecified = true;
            _useCustomSettings = value;
        }
    }

    [XmlIgnore]
    public bool UseCustomSettingsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify _userNumbers;

    [XmlElement(ElementName = "userNumbers", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify UserNumbers {
        get => _userNumbers;
        set {
            UserNumbersSpecified = true;
            _userNumbers = value;
        }
    }

    [XmlIgnore]
    public bool UserNumbersSpecified { get; set; }
}
}
