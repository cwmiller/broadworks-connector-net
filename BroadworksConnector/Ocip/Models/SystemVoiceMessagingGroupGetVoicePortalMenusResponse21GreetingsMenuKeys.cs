using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21GreetingsMenuKeys 
{
    private string _personalizedName;

    [XmlElement(ElementName = "personalizedName", IsNullable = false, Namespace = "")]
    public string PersonalizedName {
        get => _personalizedName;
        set {
            PersonalizedNameSpecified = true;
            _personalizedName = value;
        }
    }

    [XmlIgnore]
    public bool PersonalizedNameSpecified { get; set; }
    private string _conferenceGreeting;

    [XmlElement(ElementName = "conferenceGreeting", IsNullable = false, Namespace = "")]
    public string ConferenceGreeting {
        get => _conferenceGreeting;
        set {
            ConferenceGreetingSpecified = true;
            _conferenceGreeting = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceGreetingSpecified { get; set; }
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
    private string _repeatMenu;

    [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
    public string RepeatMenu {
        get => _repeatMenu;
        set {
            RepeatMenuSpecified = true;
            _repeatMenu = value;
        }
    }

    [XmlIgnore]
    public bool RepeatMenuSpecified { get; set; }
}
}
