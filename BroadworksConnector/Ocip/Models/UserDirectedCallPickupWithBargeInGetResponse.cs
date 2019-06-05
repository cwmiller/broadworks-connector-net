using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectedCallPickupWithBargeInGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
