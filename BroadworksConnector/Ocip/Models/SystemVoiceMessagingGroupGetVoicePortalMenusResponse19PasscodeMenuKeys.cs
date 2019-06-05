using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PasscodeMenuKeys 
{
    private string _finishEnteringOrReenteringPasscode;

    [XmlElement(ElementName = "finishEnteringOrReenteringPasscode", IsNullable = false, Namespace = "")]
    public string FinishEnteringOrReenteringPasscode {
        get => _finishEnteringOrReenteringPasscode;
        set {
            FinishEnteringOrReenteringPasscodeSpecified = true;
            _finishEnteringOrReenteringPasscode = value;
        }
    }

    [XmlIgnore]
    public bool FinishEnteringOrReenteringPasscodeSpecified { get; set; }
    private string _returnToPreviousMenu;

    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
    public string ReturnToPreviousMenu {
        get => _returnToPreviousMenu;
        set {
            ReturnToPreviousMenuSpecified = true;
            _returnToPreviousMenu = value;
        }
    }

    [XmlIgnore]
    public bool ReturnToPreviousMenuSpecified { get; set; }
}
}
