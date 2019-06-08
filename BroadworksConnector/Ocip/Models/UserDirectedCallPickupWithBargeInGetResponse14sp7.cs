using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectedCallPickupWithBargeInGetResponse14sp7 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
