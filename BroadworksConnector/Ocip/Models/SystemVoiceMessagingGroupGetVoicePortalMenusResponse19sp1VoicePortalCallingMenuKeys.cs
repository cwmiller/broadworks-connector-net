using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1VoicePortalCallingMenuKeys 
{
    private string _endCurrentCallAndGoBackToPreviousMenu;

    [XmlElement(ElementName = "endCurrentCallAndGoBackToPreviousMenu", IsNullable = false, Namespace = "")]
    public string EndCurrentCallAndGoBackToPreviousMenu {
        get => _endCurrentCallAndGoBackToPreviousMenu;
        set {
            EndCurrentCallAndGoBackToPreviousMenuSpecified = true;
            _endCurrentCallAndGoBackToPreviousMenu = value;
        }
    }

    [XmlIgnore]
    public bool EndCurrentCallAndGoBackToPreviousMenuSpecified { get; set; }
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
