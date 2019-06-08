using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ChangeBusyOrNoAnswerGreetingMenuKeysModifyEntry 
{
    private string _recordNewGreeting;

    [XmlElement(ElementName = "recordNewGreeting", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = true, Namespace = "")]
    public string ListenToCurrentGreeting {
        get => _listenToCurrentGreeting;
        set {
            ListenToCurrentGreetingSpecified = true;
            _listenToCurrentGreeting = value;
        }
    }

    [XmlIgnore]
    public bool ListenToCurrentGreetingSpecified { get; set; }
    private string _revertToSystemDefaultGreeting;

    [XmlElement(ElementName = "revertToSystemDefaultGreeting", IsNullable = true, Namespace = "")]
    public string RevertToSystemDefaultGreeting {
        get => _revertToSystemDefaultGreeting;
        set {
            RevertToSystemDefaultGreetingSpecified = true;
            _revertToSystemDefaultGreeting = value;
        }
    }

    [XmlIgnore]
    public bool RevertToSystemDefaultGreetingSpecified { get; set; }
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

    [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
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
