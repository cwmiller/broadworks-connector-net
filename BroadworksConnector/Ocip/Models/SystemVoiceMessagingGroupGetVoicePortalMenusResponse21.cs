using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useVoicePortalCustomization;

    [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false, Namespace = "")]
    public bool UseVoicePortalCustomization {
        get => _useVoicePortalCustomization;
        set {
            UseVoicePortalCustomizationSpecified = true;
            _useVoicePortalCustomization = value;
        }
    }

    [XmlIgnore]
    public bool UseVoicePortalCustomizationSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoicePortalMainMenuKeys _voicePortalMainMenuKeys;

    [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoicePortalMainMenuKeys VoicePortalMainMenuKeys {
        get => _voicePortalMainMenuKeys;
        set {
            VoicePortalMainMenuKeysSpecified = true;
            _voicePortalMainMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalMainMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21AnnouncementMenuKeys _announcementMenuKeys;

    [XmlElement(ElementName = "announcementMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21AnnouncementMenuKeys AnnouncementMenuKeys {
        get => _announcementMenuKeys;
        set {
            AnnouncementMenuKeysSpecified = true;
            _announcementMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21AnnouncementRecordingMenuKeys _announcementRecordingMenuKeys;

    [XmlElement(ElementName = "announcementRecordingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21AnnouncementRecordingMenuKeys AnnouncementRecordingMenuKeys {
        get => _announcementRecordingMenuKeys;
        set {
            AnnouncementRecordingMenuKeysSpecified = true;
            _announcementRecordingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementRecordingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21GreetingsMenuKeys _greetingsMenuKeys;

    [XmlElement(ElementName = "greetingsMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21GreetingsMenuKeys GreetingsMenuKeys {
        get => _greetingsMenuKeys;
        set {
            GreetingsMenuKeysSpecified = true;
            _greetingsMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool GreetingsMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ConferenceGreetingMenuKeys _conferenceGreetingMenuKeys;

    [XmlElement(ElementName = "conferenceGreetingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ConferenceGreetingMenuKeys ConferenceGreetingMenuKeys {
        get => _conferenceGreetingMenuKeys;
        set {
            ConferenceGreetingMenuKeysSpecified = true;
            _conferenceGreetingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceGreetingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoiceMessagingMenuKeys _voiceMessagingMenuKeys;

    [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoiceMessagingMenuKeys VoiceMessagingMenuKeys {
        get => _voiceMessagingMenuKeys;
        set {
            VoiceMessagingMenuKeysSpecified = true;
            _voiceMessagingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PlayGreetingMenuKeys _playGreetingMenuKeys;

    [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PlayGreetingMenuKeys PlayGreetingMenuKeys {
        get => _playGreetingMenuKeys;
        set {
            PlayGreetingMenuKeysSpecified = true;
            _playGreetingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PlayGreetingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeBusyOrNoAnswerGreetingMenuKeys _changeBusyOrNoAnswerGreetingMenuKeys;

    [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys {
        get => _changeBusyOrNoAnswerGreetingMenuKeys;
        set {
            ChangeBusyOrNoAnswerGreetingMenuKeysSpecified = true;
            _changeBusyOrNoAnswerGreetingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ChangeBusyOrNoAnswerGreetingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeExtendedAwayGreetingMenuKeys _changeExtendedAwayGreetingMenuKeys;

    [XmlElement(ElementName = "changeExtendedAwayGreetingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeExtendedAwayGreetingMenuKeys ChangeExtendedAwayGreetingMenuKeys {
        get => _changeExtendedAwayGreetingMenuKeys;
        set {
            ChangeExtendedAwayGreetingMenuKeysSpecified = true;
            _changeExtendedAwayGreetingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ChangeExtendedAwayGreetingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21RecordNewGreetingOrPersonalizedNameMenuKeys _recordNewGreetingOrPersonalizedNameMenuKeys;

    [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys {
        get => _recordNewGreetingOrPersonalizedNameMenuKeys;
        set {
            RecordNewGreetingOrPersonalizedNameMenuKeysSpecified = true;
            _recordNewGreetingOrPersonalizedNameMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool RecordNewGreetingOrPersonalizedNameMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21DeleteAllMessagesMenuKeys _deleteAllMessagesMenuKeys;

    [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys {
        get => _deleteAllMessagesMenuKeys;
        set {
            DeleteAllMessagesMenuKeysSpecified = true;
            _deleteAllMessagesMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool DeleteAllMessagesMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21CommPilotExpressProfileMenuKeys _commPilotExpressProfileMenuKeys;

    [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys {
        get => _commPilotExpressProfileMenuKeys;
        set {
            CommPilotExpressProfileMenuKeysSpecified = true;
            _commPilotExpressProfileMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool CommPilotExpressProfileMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PersonalizedNameMenuKeys _personalizedNameMenuKeys;

    [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PersonalizedNameMenuKeys PersonalizedNameMenuKeys {
        get => _personalizedNameMenuKeys;
        set {
            PersonalizedNameMenuKeysSpecified = true;
            _personalizedNameMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PersonalizedNameMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21CallForwardingOptionsMenuKeys _callForwardingOptionsMenuKeys;

    [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys {
        get => _callForwardingOptionsMenuKeys;
        set {
            CallForwardingOptionsMenuKeysSpecified = true;
            _callForwardingOptionsMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool CallForwardingOptionsMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeCallForwardingDestinationMenuKeys _changeCallForwardingDestinationMenuKeys;

    [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys {
        get => _changeCallForwardingDestinationMenuKeys;
        set {
            ChangeCallForwardingDestinationMenuKeysSpecified = true;
            _changeCallForwardingDestinationMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ChangeCallForwardingDestinationMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoicePortalCallingMenuKeys _voicePortalCallingMenuKeys;

    [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys {
        get => _voicePortalCallingMenuKeys;
        set {
            VoicePortalCallingMenuKeysSpecified = true;
            _voicePortalCallingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalCallingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21HotelingMenuKeys _hotelingMenuKeys;

    [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21HotelingMenuKeys HotelingMenuKeys {
        get => _hotelingMenuKeys;
        set {
            HotelingMenuKeysSpecified = true;
            _hotelingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool HotelingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PasscodeMenuKeys _passcodeMenuKeys;

    [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PasscodeMenuKeys PasscodeMenuKeys {
        get => _passcodeMenuKeys;
        set {
            PasscodeMenuKeysSpecified = true;
            _passcodeMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PasscodeMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PlayMessagesMenuKeys _playMessagesMenuKeys;

    [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PlayMessagesMenuKeys PlayMessagesMenuKeys {
        get => _playMessagesMenuKeys;
        set {
            PlayMessagesMenuKeysSpecified = true;
            _playMessagesMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PlayMessagesMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PlayMessageMenuKeys _playMessageMenuKeys;

    [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PlayMessageMenuKeys PlayMessageMenuKeys {
        get => _playMessageMenuKeys;
        set {
            PlayMessageMenuKeysSpecified = true;
            _playMessageMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PlayMessageMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21AdditionalMessageOptionsMenuKeys _additionalMessageOptionsMenuKeys;

    [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys {
        get => _additionalMessageOptionsMenuKeys;
        set {
            AdditionalMessageOptionsMenuKeysSpecified = true;
            _additionalMessageOptionsMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool AdditionalMessageOptionsMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ForwardOrComposeMessageMenuKeys _forwardOrComposeMessageMenuKeys;

    [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys {
        get => _forwardOrComposeMessageMenuKeys;
        set {
            ForwardOrComposeMessageMenuKeysSpecified = true;
            _forwardOrComposeMessageMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ForwardOrComposeMessageMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ReplyMessageMenuKeys _replyMessageMenuKeys;

    [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ReplyMessageMenuKeys ReplyMessageMenuKeys {
        get => _replyMessageMenuKeys;
        set {
            ReplyMessageMenuKeysSpecified = true;
            _replyMessageMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ReplyMessageMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendToDistributionListMenuKeys _sendToDistributionListMenuKeys;

    [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendToDistributionListMenuKeys SendToDistributionListMenuKeys {
        get => _sendToDistributionListMenuKeys;
        set {
            SendToDistributionListMenuKeysSpecified = true;
            _sendToDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendToDistributionListMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SelectDistributionListMenuKeys _selectDistributionListMenuKeys;

    [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SelectDistributionListMenuKeys SelectDistributionListMenuKeys {
        get => _selectDistributionListMenuKeys;
        set {
            SelectDistributionListMenuKeysSpecified = true;
            _selectDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SelectDistributionListMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ReviewSelectedDistributionListMenuKeys _reviewSelectedDistributionListMenuKeys;

    [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys {
        get => _reviewSelectedDistributionListMenuKeys;
        set {
            ReviewSelectedDistributionListMenuKeysSpecified = true;
            _reviewSelectedDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ReviewSelectedDistributionListMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendMessageToSelectedDistributionListMenuKeys _sendMessageToSelectedDistributionListMenuKeys;

    [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys {
        get => _sendMessageToSelectedDistributionListMenuKeys;
        set {
            SendMessageToSelectedDistributionListMenuKeysSpecified = true;
            _sendMessageToSelectedDistributionListMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendMessageToSelectedDistributionListMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendToAllGroupMembersMenuKeys _sendToAllGroupMembersMenuKeys;

    [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys {
        get => _sendToAllGroupMembersMenuKeys;
        set {
            SendToAllGroupMembersMenuKeysSpecified = true;
            _sendToAllGroupMembersMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendToAllGroupMembersMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendToPersonMenuKeys _sendToPersonMenuKeys;

    [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendToPersonMenuKeys SendToPersonMenuKeys {
        get => _sendToPersonMenuKeys;
        set {
            SendToPersonMenuKeysSpecified = true;
            _sendToPersonMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool SendToPersonMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeCurrentIntroductionOrMessageOrReplyMenuKeys _changeCurrentIntroductionOrMessageOrReplyMenuKeys;

    [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys {
        get => _changeCurrentIntroductionOrMessageOrReplyMenuKeys;
        set {
            ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified = true;
            _changeCurrentIntroductionOrMessageOrReplyMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoicePortalLoginMenuKeys _voicePortalLoginMenuKeys;

    [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys {
        get => _voicePortalLoginMenuKeys;
        set {
            VoicePortalLoginMenuKeysSpecified = true;
            _voicePortalLoginMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalLoginMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21FaxMessagingMenuKeys _faxMessagingMenuKeys;

    [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21FaxMessagingMenuKeys FaxMessagingMenuKeys {
        get => _faxMessagingMenuKeys;
        set {
            FaxMessagingMenuKeysSpecified = true;
            _faxMessagingMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool FaxMessagingMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21MessageDepositMenuKeys _messageDepositMenuKeys;

    [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21MessageDepositMenuKeys MessageDepositMenuKeys {
        get => _messageDepositMenuKeys;
        set {
            MessageDepositMenuKeysSpecified = true;
            _messageDepositMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool MessageDepositMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21DisableMessageDepositMenuKeys _disableMessageDepositMenuKeys;

    [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys {
        get => _disableMessageDepositMenuKeys;
        set {
            DisableMessageDepositMenuKeysSpecified = true;
            _disableMessageDepositMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool DisableMessageDepositMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21GreetingOnlyForwardingDestinationMenuKeys _greetingOnlyForwardingDestinationMenuKeys;

    [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys {
        get => _greetingOnlyForwardingDestinationMenuKeys;
        set {
            GreetingOnlyForwardingDestinationMenuKeysSpecified = true;
            _greetingOnlyForwardingDestinationMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool GreetingOnlyForwardingDestinationMenuKeysSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PersonalAssistantMenuKeys _personalAssistantMenuKeys;

    [XmlElement(ElementName = "personalAssistantMenuKeys", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PersonalAssistantMenuKeys PersonalAssistantMenuKeys {
        get => _personalAssistantMenuKeys;
        set {
            PersonalAssistantMenuKeysSpecified = true;
            _personalAssistantMenuKeys = value;
        }
    }

    [XmlIgnore]
    public bool PersonalAssistantMenuKeysSpecified { get; set; }
}
}
