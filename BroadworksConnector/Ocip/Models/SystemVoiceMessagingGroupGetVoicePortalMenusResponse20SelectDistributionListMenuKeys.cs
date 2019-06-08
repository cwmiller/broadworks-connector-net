using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20SelectDistributionListMenuKeys 
{
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
    private string _repeatMenuOrFinishEnteringDistributionListNumber;

    [XmlElement(ElementName = "repeatMenuOrFinishEnteringDistributionListNumber", IsNullable = false, Namespace = "")]
    public string RepeatMenuOrFinishEnteringDistributionListNumber {
        get => _repeatMenuOrFinishEnteringDistributionListNumber;
        set {
            RepeatMenuOrFinishEnteringDistributionListNumberSpecified = true;
            _repeatMenuOrFinishEnteringDistributionListNumber = value;
        }
    }

    [XmlIgnore]
    public bool RepeatMenuOrFinishEnteringDistributionListNumberSpecified { get; set; }
}
}
