using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectedCallPickupWithBargeInModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _enableBargeInWarningTone;

    [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false, Namespace = "")]
    public bool EnableBargeInWarningTone {
        get => _enableBargeInWarningTone;
        set {
            EnableBargeInWarningToneSpecified = true;
            _enableBargeInWarningTone = value;
        }
    }

    [XmlIgnore]
    public bool EnableBargeInWarningToneSpecified { get; set; }
    private bool _enableAutomaticTargetSelection;

    [XmlElement(ElementName = "enableAutomaticTargetSelection", IsNullable = false, Namespace = "")]
    public bool EnableAutomaticTargetSelection {
        get => _enableAutomaticTargetSelection;
        set {
            EnableAutomaticTargetSelectionSpecified = true;
            _enableAutomaticTargetSelection = value;
        }
    }

    [XmlIgnore]
    public bool EnableAutomaticTargetSelectionSpecified { get; set; }
}
}
