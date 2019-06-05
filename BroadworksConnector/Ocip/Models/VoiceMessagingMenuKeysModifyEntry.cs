using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoiceMessagingMenuKeysModifyEntry 
{
    private string _playMessages;

    [XmlElement(ElementName = "playMessages", IsNullable = true, Namespace = "")]
    public string PlayMessages {
        get => _playMessages;
        set {
            PlayMessagesSpecified = true;
            _playMessages = value;
        }
    }

    [XmlIgnore]
    public bool PlayMessagesSpecified { get; set; }
    private string _changeBusyGreeting;

    [XmlElement(ElementName = "changeBusyGreeting", IsNullable = true, Namespace = "")]
    public string ChangeBusyGreeting {
        get => _changeBusyGreeting;
        set {
            ChangeBusyGreetingSpecified = true;
            _changeBusyGreeting = value;
        }
    }

    [XmlIgnore]
    public bool ChangeBusyGreetingSpecified { get; set; }
    private string _changeNoAnswerGreeting;

    [XmlElement(ElementName = "changeNoAnswerGreeting", IsNullable = true, Namespace = "")]
    public string ChangeNoAnswerGreeting {
        get => _changeNoAnswerGreeting;
        set {
            ChangeNoAnswerGreetingSpecified = true;
            _changeNoAnswerGreeting = value;
        }
    }

    [XmlIgnore]
    public bool ChangeNoAnswerGreetingSpecified { get; set; }
    private string _changeExtendedAwayGreeting;

    [XmlElement(ElementName = "changeExtendedAwayGreeting", IsNullable = true, Namespace = "")]
    public string ChangeExtendedAwayGreeting {
        get => _changeExtendedAwayGreeting;
        set {
            ChangeExtendedAwayGreetingSpecified = true;
            _changeExtendedAwayGreeting = value;
        }
    }

    [XmlIgnore]
    public bool ChangeExtendedAwayGreetingSpecified { get; set; }
    private string _composeMessage;

    [XmlElement(ElementName = "composeMessage", IsNullable = true, Namespace = "")]
    public string ComposeMessage {
        get => _composeMessage;
        set {
            ComposeMessageSpecified = true;
            _composeMessage = value;
        }
    }

    [XmlIgnore]
    public bool ComposeMessageSpecified { get; set; }
    private string _deleteAllMessages;

    [XmlElement(ElementName = "deleteAllMessages", IsNullable = true, Namespace = "")]
    public string DeleteAllMessages {
        get => _deleteAllMessages;
        set {
            DeleteAllMessagesSpecified = true;
            _deleteAllMessages = value;
        }
    }

    [XmlIgnore]
    public bool DeleteAllMessagesSpecified { get; set; }
    private string _passcode;

    [XmlElement(ElementName = "passcode", IsNullable = true, Namespace = "")]
    public string Passcode {
        get => _passcode;
        set {
            PasscodeSpecified = true;
            _passcode = value;
        }
    }

    [XmlIgnore]
    public bool PasscodeSpecified { get; set; }
    private string _personalizedName;

    [XmlElement(ElementName = "personalizedName", IsNullable = true, Namespace = "")]
    public string PersonalizedName {
        get => _personalizedName;
        set {
            PersonalizedNameSpecified = true;
            _personalizedName = value;
        }
    }

    [XmlIgnore]
    public bool PersonalizedNameSpecified { get; set; }
    private string _messageDeposit;

    [XmlElement(ElementName = "messageDeposit", IsNullable = true, Namespace = "")]
    public string MessageDeposit {
        get => _messageDeposit;
        set {
            MessageDepositSpecified = true;
            _messageDeposit = value;
        }
    }

    [XmlIgnore]
    public bool MessageDepositSpecified { get; set; }
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
