using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectedCallPickupWithBargeInGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
}
}
