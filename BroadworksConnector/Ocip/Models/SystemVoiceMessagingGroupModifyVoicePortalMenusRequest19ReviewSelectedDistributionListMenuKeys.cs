using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReviewSelectedDistributionListMenuKeys 
{
    private string _interruptPlaybackAndReturnToPreviousMenu;

    [XmlElement(ElementName = "interruptPlaybackAndReturnToPreviousMenu", IsNullable = false, Namespace = "")]
    public string InterruptPlaybackAndReturnToPreviousMenu {
        get => _interruptPlaybackAndReturnToPreviousMenu;
        set {
            InterruptPlaybackAndReturnToPreviousMenuSpecified = true;
            _interruptPlaybackAndReturnToPreviousMenu = value;
        }
    }

    [XmlIgnore]
    public bool InterruptPlaybackAndReturnToPreviousMenuSpecified { get; set; }
}
}
