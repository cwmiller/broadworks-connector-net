using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PersonalAssistantMenuKeysReadEntry 
{
    private string _setPresenceToNone;

    [XmlElement(ElementName = "setPresenceToNone", IsNullable = false, Namespace = "")]
    public string SetPresenceToNone {
        get => _setPresenceToNone;
        set {
            SetPresenceToNoneSpecified = true;
            _setPresenceToNone = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToNoneSpecified { get; set; }
    private string _setPresenceToBusinessTrip;

    [XmlElement(ElementName = "setPresenceToBusinessTrip", IsNullable = false, Namespace = "")]
    public string SetPresenceToBusinessTrip {
        get => _setPresenceToBusinessTrip;
        set {
            SetPresenceToBusinessTripSpecified = true;
            _setPresenceToBusinessTrip = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToBusinessTripSpecified { get; set; }
    private string _setPresenceToGoneForTheDay;

    [XmlElement(ElementName = "setPresenceToGoneForTheDay", IsNullable = false, Namespace = "")]
    public string SetPresenceToGoneForTheDay {
        get => _setPresenceToGoneForTheDay;
        set {
            SetPresenceToGoneForTheDaySpecified = true;
            _setPresenceToGoneForTheDay = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToGoneForTheDaySpecified { get; set; }
    private string _setPresenceToLunch;

    [XmlElement(ElementName = "setPresenceToLunch", IsNullable = false, Namespace = "")]
    public string SetPresenceToLunch {
        get => _setPresenceToLunch;
        set {
            SetPresenceToLunchSpecified = true;
            _setPresenceToLunch = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToLunchSpecified { get; set; }
    private string _setPresenceToMeeting;

    [XmlElement(ElementName = "setPresenceToMeeting", IsNullable = false, Namespace = "")]
    public string SetPresenceToMeeting {
        get => _setPresenceToMeeting;
        set {
            SetPresenceToMeetingSpecified = true;
            _setPresenceToMeeting = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToMeetingSpecified { get; set; }
    private string _setPresenceToOutOfOffice;

    [XmlElement(ElementName = "setPresenceToOutOfOffice", IsNullable = false, Namespace = "")]
    public string SetPresenceToOutOfOffice {
        get => _setPresenceToOutOfOffice;
        set {
            SetPresenceToOutOfOfficeSpecified = true;
            _setPresenceToOutOfOffice = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToOutOfOfficeSpecified { get; set; }
    private string _setPresenceToTemporarilyOut;

    [XmlElement(ElementName = "setPresenceToTemporarilyOut", IsNullable = false, Namespace = "")]
    public string SetPresenceToTemporarilyOut {
        get => _setPresenceToTemporarilyOut;
        set {
            SetPresenceToTemporarilyOutSpecified = true;
            _setPresenceToTemporarilyOut = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToTemporarilyOutSpecified { get; set; }
    private string _setPresenceToTraining;

    [XmlElement(ElementName = "setPresenceToTraining", IsNullable = false, Namespace = "")]
    public string SetPresenceToTraining {
        get => _setPresenceToTraining;
        set {
            SetPresenceToTrainingSpecified = true;
            _setPresenceToTraining = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToTrainingSpecified { get; set; }
    private string _setPresenceToUnavailable;

    [XmlElement(ElementName = "setPresenceToUnavailable", IsNullable = false, Namespace = "")]
    public string SetPresenceToUnavailable {
        get => _setPresenceToUnavailable;
        set {
            SetPresenceToUnavailableSpecified = true;
            _setPresenceToUnavailable = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToUnavailableSpecified { get; set; }
    private string _setPresenceToVacation;

    [XmlElement(ElementName = "setPresenceToVacation", IsNullable = false, Namespace = "")]
    public string SetPresenceToVacation {
        get => _setPresenceToVacation;
        set {
            SetPresenceToVacationSpecified = true;
            _setPresenceToVacation = value;
        }
    }

    [XmlIgnore]
    public bool SetPresenceToVacationSpecified { get; set; }
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