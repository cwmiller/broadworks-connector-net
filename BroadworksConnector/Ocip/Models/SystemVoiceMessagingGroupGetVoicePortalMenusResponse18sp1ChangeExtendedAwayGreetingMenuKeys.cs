using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeExtendedAwayGreetingMenuKeys 
{
    private string _activateExtendedAwayGreeting;

    [XmlElement(ElementName = "activateExtendedAwayGreeting", IsNullable = false, Namespace = "")]
    public string ActivateExtendedAwayGreeting {
        get => _activateExtendedAwayGreeting;
        set {
            ActivateExtendedAwayGreetingSpecified = true;
            _activateExtendedAwayGreeting = value;
        }
    }

    [XmlIgnore]
    public bool ActivateExtendedAwayGreetingSpecified { get; set; }
    private string _deactivateExtendedAwayGreeting;

    [XmlElement(ElementName = "deactivateExtendedAwayGreeting", IsNullable = false, Namespace = "")]
    public string DeactivateExtendedAwayGreeting {
        get => _deactivateExtendedAwayGreeting;
        set {
            DeactivateExtendedAwayGreetingSpecified = true;
            _deactivateExtendedAwayGreeting = value;
        }
    }

    [XmlIgnore]
    public bool DeactivateExtendedAwayGreetingSpecified { get; set; }
    private string _recordNewGreeting;

    [XmlElement(ElementName = "recordNewGreeting", IsNullable = false, Namespace = "")]
    public string RecordNewGreeting {
        get => _recordNewGreeting;
        set {
            RecordNewGreetingSpecified = true;
            _recordNewGreeting = value;
        }
    }

    [XmlIgnore]
    public bool RecordNewGreetingSpecified { get; set; }
    private string _listenToCurrentGreeting;

    [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = false, Namespace = "")]
    public string ListenToCurrentGreeting {
        get => _listenToCurrentGreeting;
        set {
            ListenToCurrentGreetingSpecified = true;
            _listenToCurrentGreeting = value;
        }
    }

    [XmlIgnore]
    public bool ListenToCurrentGreetingSpecified { get; set; }
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
