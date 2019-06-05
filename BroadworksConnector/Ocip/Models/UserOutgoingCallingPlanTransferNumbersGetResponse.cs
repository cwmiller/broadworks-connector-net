using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanTransferNumbersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers _userNumbers;

    [XmlElement(ElementName = "userNumbers", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers UserNumbers {
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
