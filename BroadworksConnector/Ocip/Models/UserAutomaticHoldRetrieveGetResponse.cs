using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAutomaticHoldRetrieveGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private int _recallTimerSeconds;

    [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
    public int RecallTimerSeconds {
        get => _recallTimerSeconds;
        set {
            RecallTimerSecondsSpecified = true;
            _recallTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RecallTimerSecondsSpecified { get; set; }
}
}
