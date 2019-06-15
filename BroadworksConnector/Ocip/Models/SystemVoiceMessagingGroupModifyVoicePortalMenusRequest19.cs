using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system voice portal menus setting.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalMainMenuKeys _voicePortalMainMenuKeys;

        [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalMainMenuKeys VoicePortalMainMenuKeys {
            get => _voicePortalMainMenuKeys;
            set {
                VoicePortalMainMenuKeysSpecified = true;
                _voicePortalMainMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalMainMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementMenuKeys _announcementMenuKeys;

        [XmlElement(ElementName = "announcementMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementMenuKeys AnnouncementMenuKeys {
            get => _announcementMenuKeys;
            set {
                AnnouncementMenuKeysSpecified = true;
                _announcementMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementRecordingMenuKeys _announcementRecordingMenuKeys;

        [XmlElement(ElementName = "announcementRecordingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementRecordingMenuKeys AnnouncementRecordingMenuKeys {
            get => _announcementRecordingMenuKeys;
            set {
                AnnouncementRecordingMenuKeysSpecified = true;
                _announcementRecordingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementRecordingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingsMenuKeys _greetingsMenuKeys;

        [XmlElement(ElementName = "greetingsMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingsMenuKeys GreetingsMenuKeys {
            get => _greetingsMenuKeys;
            set {
                GreetingsMenuKeysSpecified = true;
                _greetingsMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool GreetingsMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ConferenceGreetingMenuKeys _conferenceGreetingMenuKeys;

        [XmlElement(ElementName = "conferenceGreetingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ConferenceGreetingMenuKeys ConferenceGreetingMenuKeys {
            get => _conferenceGreetingMenuKeys;
            set {
                ConferenceGreetingMenuKeysSpecified = true;
                _conferenceGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceGreetingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoiceMessagingMenuKeys _voiceMessagingMenuKeys;

        [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoiceMessagingMenuKeys VoiceMessagingMenuKeys {
            get => _voiceMessagingMenuKeys;
            set {
                VoiceMessagingMenuKeysSpecified = true;
                _voiceMessagingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMessagingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayGreetingMenuKeys _playGreetingMenuKeys;

        [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayGreetingMenuKeys PlayGreetingMenuKeys {
            get => _playGreetingMenuKeys;
            set {
                PlayGreetingMenuKeysSpecified = true;
                _playGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool PlayGreetingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeBusyOrNoAnswerGreetingMenuKeys _changeBusyOrNoAnswerGreetingMenuKeys;

        [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys {
            get => _changeBusyOrNoAnswerGreetingMenuKeys;
            set {
                ChangeBusyOrNoAnswerGreetingMenuKeysSpecified = true;
                _changeBusyOrNoAnswerGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ChangeBusyOrNoAnswerGreetingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeExtendedAwayGreetingMenuKeys _changeExtendedAwayGreetingMenuKeys;

        [XmlElement(ElementName = "changeExtendedAwayGreetingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeExtendedAwayGreetingMenuKeys ChangeExtendedAwayGreetingMenuKeys {
            get => _changeExtendedAwayGreetingMenuKeys;
            set {
                ChangeExtendedAwayGreetingMenuKeysSpecified = true;
                _changeExtendedAwayGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ChangeExtendedAwayGreetingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19RecordNewGreetingOrPersonalizedNameMenuKeys _recordNewGreetingOrPersonalizedNameMenuKeys;

        [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys {
            get => _recordNewGreetingOrPersonalizedNameMenuKeys;
            set {
                RecordNewGreetingOrPersonalizedNameMenuKeysSpecified = true;
                _recordNewGreetingOrPersonalizedNameMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool RecordNewGreetingOrPersonalizedNameMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DeleteAllMessagesMenuKeys _deleteAllMessagesMenuKeys;

        [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys {
            get => _deleteAllMessagesMenuKeys;
            set {
                DeleteAllMessagesMenuKeysSpecified = true;
                _deleteAllMessagesMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool DeleteAllMessagesMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CommPilotExpressProfileMenuKeys _commPilotExpressProfileMenuKeys;

        [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys {
            get => _commPilotExpressProfileMenuKeys;
            set {
                CommPilotExpressProfileMenuKeysSpecified = true;
                _commPilotExpressProfileMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool CommPilotExpressProfileMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalizedNameMenuKeys _personalizedNameMenuKeys;

        [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalizedNameMenuKeys PersonalizedNameMenuKeys {
            get => _personalizedNameMenuKeys;
            set {
                PersonalizedNameMenuKeysSpecified = true;
                _personalizedNameMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool PersonalizedNameMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CallForwardingOptionsMenuKeys _callForwardingOptionsMenuKeys;

        [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys {
            get => _callForwardingOptionsMenuKeys;
            set {
                CallForwardingOptionsMenuKeysSpecified = true;
                _callForwardingOptionsMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool CallForwardingOptionsMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCallForwardingDestinationMenuKeys _changeCallForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys {
            get => _changeCallForwardingDestinationMenuKeys;
            set {
                ChangeCallForwardingDestinationMenuKeysSpecified = true;
                _changeCallForwardingDestinationMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ChangeCallForwardingDestinationMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalCallingMenuKeys _voicePortalCallingMenuKeys;

        [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys {
            get => _voicePortalCallingMenuKeys;
            set {
                VoicePortalCallingMenuKeysSpecified = true;
                _voicePortalCallingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalCallingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19HotelingMenuKeys _hotelingMenuKeys;

        [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19HotelingMenuKeys HotelingMenuKeys {
            get => _hotelingMenuKeys;
            set {
                HotelingMenuKeysSpecified = true;
                _hotelingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool HotelingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PasscodeMenuKeys _passcodeMenuKeys;

        [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PasscodeMenuKeys PasscodeMenuKeys {
            get => _passcodeMenuKeys;
            set {
                PasscodeMenuKeysSpecified = true;
                _passcodeMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool PasscodeMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessagesMenuKeys _playMessagesMenuKeys;

        [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessagesMenuKeys PlayMessagesMenuKeys {
            get => _playMessagesMenuKeys;
            set {
                PlayMessagesMenuKeysSpecified = true;
                _playMessagesMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool PlayMessagesMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessageMenuKeys _playMessageMenuKeys;

        [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessageMenuKeys PlayMessageMenuKeys {
            get => _playMessageMenuKeys;
            set {
                PlayMessageMenuKeysSpecified = true;
                _playMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool PlayMessageMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AdditionalMessageOptionsMenuKeys _additionalMessageOptionsMenuKeys;

        [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys {
            get => _additionalMessageOptionsMenuKeys;
            set {
                AdditionalMessageOptionsMenuKeysSpecified = true;
                _additionalMessageOptionsMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool AdditionalMessageOptionsMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ForwardOrComposeMessageMenuKeys _forwardOrComposeMessageMenuKeys;

        [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys {
            get => _forwardOrComposeMessageMenuKeys;
            set {
                ForwardOrComposeMessageMenuKeysSpecified = true;
                _forwardOrComposeMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ForwardOrComposeMessageMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReplyMessageMenuKeys _replyMessageMenuKeys;

        [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReplyMessageMenuKeys ReplyMessageMenuKeys {
            get => _replyMessageMenuKeys;
            set {
                ReplyMessageMenuKeysSpecified = true;
                _replyMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ReplyMessageMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToDistributionListMenuKeys _sendToDistributionListMenuKeys;

        [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToDistributionListMenuKeys SendToDistributionListMenuKeys {
            get => _sendToDistributionListMenuKeys;
            set {
                SendToDistributionListMenuKeysSpecified = true;
                _sendToDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool SendToDistributionListMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SelectDistributionListMenuKeys _selectDistributionListMenuKeys;

        [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SelectDistributionListMenuKeys SelectDistributionListMenuKeys {
            get => _selectDistributionListMenuKeys;
            set {
                SelectDistributionListMenuKeysSpecified = true;
                _selectDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool SelectDistributionListMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReviewSelectedDistributionListMenuKeys _reviewSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys {
            get => _reviewSelectedDistributionListMenuKeys;
            set {
                ReviewSelectedDistributionListMenuKeysSpecified = true;
                _reviewSelectedDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ReviewSelectedDistributionListMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendMessageToSelectedDistributionListMenuKeys _sendMessageToSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys {
            get => _sendMessageToSelectedDistributionListMenuKeys;
            set {
                SendMessageToSelectedDistributionListMenuKeysSpecified = true;
                _sendMessageToSelectedDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool SendMessageToSelectedDistributionListMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToAllGroupMembersMenuKeys _sendToAllGroupMembersMenuKeys;

        [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys {
            get => _sendToAllGroupMembersMenuKeys;
            set {
                SendToAllGroupMembersMenuKeysSpecified = true;
                _sendToAllGroupMembersMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool SendToAllGroupMembersMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToPersonMenuKeys _sendToPersonMenuKeys;

        [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToPersonMenuKeys SendToPersonMenuKeys {
            get => _sendToPersonMenuKeys;
            set {
                SendToPersonMenuKeysSpecified = true;
                _sendToPersonMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool SendToPersonMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCurrentIntroductionOrMessageOrReplyMenuKeys _changeCurrentIntroductionOrMessageOrReplyMenuKeys;

        [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys {
            get => _changeCurrentIntroductionOrMessageOrReplyMenuKeys;
            set {
                ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified = true;
                _changeCurrentIntroductionOrMessageOrReplyMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalLoginMenuKeys _voicePortalLoginMenuKeys;

        [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys {
            get => _voicePortalLoginMenuKeys;
            set {
                VoicePortalLoginMenuKeysSpecified = true;
                _voicePortalLoginMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalLoginMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19FaxMessagingMenuKeys _faxMessagingMenuKeys;

        [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19FaxMessagingMenuKeys FaxMessagingMenuKeys {
            get => _faxMessagingMenuKeys;
            set {
                FaxMessagingMenuKeysSpecified = true;
                _faxMessagingMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool FaxMessagingMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19MessageDepositMenuKeys _messageDepositMenuKeys;

        [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19MessageDepositMenuKeys MessageDepositMenuKeys {
            get => _messageDepositMenuKeys;
            set {
                MessageDepositMenuKeysSpecified = true;
                _messageDepositMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool MessageDepositMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DisableMessageDepositMenuKeys _disableMessageDepositMenuKeys;

        [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys {
            get => _disableMessageDepositMenuKeys;
            set {
                DisableMessageDepositMenuKeysSpecified = true;
                _disableMessageDepositMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool DisableMessageDepositMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingOnlyForwardingDestinationMenuKeys _greetingOnlyForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys {
            get => _greetingOnlyForwardingDestinationMenuKeys;
            set {
                GreetingOnlyForwardingDestinationMenuKeysSpecified = true;
                _greetingOnlyForwardingDestinationMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool GreetingOnlyForwardingDestinationMenuKeysSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalAssistantMenuKeys _personalAssistantMenuKeys;

        [XmlElement(ElementName = "personalAssistantMenuKeys", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalAssistantMenuKeys PersonalAssistantMenuKeys {
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
