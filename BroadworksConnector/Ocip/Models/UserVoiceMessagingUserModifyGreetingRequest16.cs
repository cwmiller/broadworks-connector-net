using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyGreetingRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementSelection _busyAnnouncementSelection;

    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection {
        get => _busyAnnouncementSelection;
        set {
            BusyAnnouncementSelectionSpecified = true;
            _busyAnnouncementSelection = value;
        }
    }

    [XmlIgnore]
    public bool BusyAnnouncementSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _busyPersonalAudioFile;

    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource BusyPersonalAudioFile {
        get => _busyPersonalAudioFile;
        set {
            BusyPersonalAudioFileSpecified = true;
            _busyPersonalAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool BusyPersonalAudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _busyPersonalVideoFile;

    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource BusyPersonalVideoFile {
        get => _busyPersonalVideoFile;
        set {
            BusyPersonalVideoFileSpecified = true;
            _busyPersonalVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool BusyPersonalVideoFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection _noAnswerAnnouncementSelection;

    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection {
        get => _noAnswerAnnouncementSelection;
        set {
            NoAnswerAnnouncementSelectionSpecified = true;
            _noAnswerAnnouncementSelection = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAnnouncementSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _noAnswerPersonalAudioFile;

    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource NoAnswerPersonalAudioFile {
        get => _noAnswerPersonalAudioFile;
        set {
            NoAnswerPersonalAudioFileSpecified = true;
            _noAnswerPersonalAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerPersonalAudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _noAnswerPersonalVideoFile;

    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource NoAnswerPersonalVideoFile {
        get => _noAnswerPersonalVideoFile;
        set {
            NoAnswerPersonalVideoFileSpecified = true;
            _noAnswerPersonalVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerPersonalVideoFileSpecified { get; set; }
    private bool _extendedAwayEnabled;

    [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false, Namespace = "")]
    public bool ExtendedAwayEnabled {
        get => _extendedAwayEnabled;
        set {
            ExtendedAwayEnabledSpecified = true;
            _extendedAwayEnabled = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedAwayEnabledSpecified { get; set; }
    private bool _extendedAwayDisableMessageDeposit;

    [XmlElement(ElementName = "extendedAwayDisableMessageDeposit", IsNullable = false, Namespace = "")]
    public bool ExtendedAwayDisableMessageDeposit {
        get => _extendedAwayDisableMessageDeposit;
        set {
            ExtendedAwayDisableMessageDepositSpecified = true;
            _extendedAwayDisableMessageDeposit = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedAwayDisableMessageDepositSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _extendedAwayAudioFile;

    [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource ExtendedAwayAudioFile {
        get => _extendedAwayAudioFile;
        set {
            ExtendedAwayAudioFileSpecified = true;
            _extendedAwayAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedAwayAudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _extendedAwayVideoFile;

    [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource ExtendedAwayVideoFile {
        get => _extendedAwayVideoFile;
        set {
            ExtendedAwayVideoFileSpecified = true;
            _extendedAwayVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedAwayVideoFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 _noAnswerAlternateGreeting01;

    [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting01 {
        get => _noAnswerAlternateGreeting01;
        set {
            NoAnswerAlternateGreeting01Specified = true;
            _noAnswerAlternateGreeting01 = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAlternateGreeting01Specified { get; set; }
    private BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 _noAnswerAlternateGreeting02;

    [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting02 {
        get => _noAnswerAlternateGreeting02;
        set {
            NoAnswerAlternateGreeting02Specified = true;
            _noAnswerAlternateGreeting02 = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAlternateGreeting02Specified { get; set; }
    private BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 _noAnswerAlternateGreeting03;

    [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting03 {
        get => _noAnswerAlternateGreeting03;
        set {
            NoAnswerAlternateGreeting03Specified = true;
            _noAnswerAlternateGreeting03 = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerAlternateGreeting03Specified { get; set; }
    private BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings _noAnswerNumberOfRings;

    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings {
        get => _noAnswerNumberOfRings;
        set {
            NoAnswerNumberOfRingsSpecified = true;
            _noAnswerNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerNumberOfRingsSpecified { get; set; }
    private bool _disableMessageDeposit;

    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false, Namespace = "")]
    public bool DisableMessageDeposit {
        get => _disableMessageDeposit;
        set {
            DisableMessageDepositSpecified = true;
            _disableMessageDeposit = value;
        }
    }

    [XmlIgnore]
    public bool DisableMessageDepositSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection _disableMessageDepositAction;

    [XmlElement(ElementName = "disableMessageDepositAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection DisableMessageDepositAction {
        get => _disableMessageDepositAction;
        set {
            DisableMessageDepositActionSpecified = true;
            _disableMessageDepositAction = value;
        }
    }

    [XmlIgnore]
    public bool DisableMessageDepositActionSpecified { get; set; }
    private string _greetingOnlyForwardDestination;

    [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = true, Namespace = "")]
    public string GreetingOnlyForwardDestination {
        get => _greetingOnlyForwardDestination;
        set {
            GreetingOnlyForwardDestinationSpecified = true;
            _greetingOnlyForwardDestination = value;
        }
    }

    [XmlIgnore]
    public bool GreetingOnlyForwardDestinationSpecified { get; set; }
}
}
