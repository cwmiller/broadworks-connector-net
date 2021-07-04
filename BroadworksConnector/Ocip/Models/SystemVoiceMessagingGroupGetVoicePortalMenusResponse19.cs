using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVoiceMessagingGroupGetVoicePortalMenusRequest19.
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusRequest19"/>
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37440""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useVoicePortalCustomization;

        [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public bool UseVoicePortalCustomization
        {
            get => _useVoicePortalCustomization;
            set
            {
                UseVoicePortalCustomizationSpecified = true;
                _useVoicePortalCustomization = value;
            }
        }

        [XmlIgnore]
        protected bool UseVoicePortalCustomizationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalMainMenuKeys _voicePortalMainMenuKeys;

        [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalMainMenuKeys VoicePortalMainMenuKeys
        {
            get => _voicePortalMainMenuKeys;
            set
            {
                VoicePortalMainMenuKeysSpecified = true;
                _voicePortalMainMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalMainMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingsMenuKeys _greetingsMenuKeys;

        [XmlElement(ElementName = "greetingsMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingsMenuKeys GreetingsMenuKeys
        {
            get => _greetingsMenuKeys;
            set
            {
                GreetingsMenuKeysSpecified = true;
                _greetingsMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool GreetingsMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ConferenceGreetingMenuKeys _conferenceGreetingMenuKeys;

        [XmlElement(ElementName = "conferenceGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ConferenceGreetingMenuKeys ConferenceGreetingMenuKeys
        {
            get => _conferenceGreetingMenuKeys;
            set
            {
                ConferenceGreetingMenuKeysSpecified = true;
                _conferenceGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceGreetingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoiceMessagingMenuKeys _voiceMessagingMenuKeys;

        [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoiceMessagingMenuKeys VoiceMessagingMenuKeys
        {
            get => _voiceMessagingMenuKeys;
            set
            {
                VoiceMessagingMenuKeysSpecified = true;
                _voiceMessagingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayGreetingMenuKeys _playGreetingMenuKeys;

        [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayGreetingMenuKeys PlayGreetingMenuKeys
        {
            get => _playGreetingMenuKeys;
            set
            {
                PlayGreetingMenuKeysSpecified = true;
                _playGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PlayGreetingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeBusyOrNoAnswerGreetingMenuKeys _changeBusyOrNoAnswerGreetingMenuKeys;

        [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys
        {
            get => _changeBusyOrNoAnswerGreetingMenuKeys;
            set
            {
                ChangeBusyOrNoAnswerGreetingMenuKeysSpecified = true;
                _changeBusyOrNoAnswerGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeBusyOrNoAnswerGreetingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19RecordNewGreetingOrPersonalizedNameMenuKeys _recordNewGreetingOrPersonalizedNameMenuKeys;

        [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys
        {
            get => _recordNewGreetingOrPersonalizedNameMenuKeys;
            set
            {
                RecordNewGreetingOrPersonalizedNameMenuKeysSpecified = true;
                _recordNewGreetingOrPersonalizedNameMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool RecordNewGreetingOrPersonalizedNameMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19DeleteAllMessagesMenuKeys _deleteAllMessagesMenuKeys;

        [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys
        {
            get => _deleteAllMessagesMenuKeys;
            set
            {
                DeleteAllMessagesMenuKeysSpecified = true;
                _deleteAllMessagesMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteAllMessagesMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19CommPilotExpressProfileMenuKeys _commPilotExpressProfileMenuKeys;

        [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys
        {
            get => _commPilotExpressProfileMenuKeys;
            set
            {
                CommPilotExpressProfileMenuKeysSpecified = true;
                _commPilotExpressProfileMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool CommPilotExpressProfileMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PersonalizedNameMenuKeys _personalizedNameMenuKeys;

        [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PersonalizedNameMenuKeys PersonalizedNameMenuKeys
        {
            get => _personalizedNameMenuKeys;
            set
            {
                PersonalizedNameMenuKeysSpecified = true;
                _personalizedNameMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19CallForwardingOptionsMenuKeys _callForwardingOptionsMenuKeys;

        [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys
        {
            get => _callForwardingOptionsMenuKeys;
            set
            {
                CallForwardingOptionsMenuKeysSpecified = true;
                _callForwardingOptionsMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool CallForwardingOptionsMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeCallForwardingDestinationMenuKeys _changeCallForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys
        {
            get => _changeCallForwardingDestinationMenuKeys;
            set
            {
                ChangeCallForwardingDestinationMenuKeysSpecified = true;
                _changeCallForwardingDestinationMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCallForwardingDestinationMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalCallingMenuKeys _voicePortalCallingMenuKeys;

        [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys
        {
            get => _voicePortalCallingMenuKeys;
            set
            {
                VoicePortalCallingMenuKeysSpecified = true;
                _voicePortalCallingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalCallingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19HotelingMenuKeys _hotelingMenuKeys;

        [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19HotelingMenuKeys HotelingMenuKeys
        {
            get => _hotelingMenuKeys;
            set
            {
                HotelingMenuKeysSpecified = true;
                _hotelingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool HotelingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PasscodeMenuKeys _passcodeMenuKeys;

        [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PasscodeMenuKeys PasscodeMenuKeys
        {
            get => _passcodeMenuKeys;
            set
            {
                PasscodeMenuKeysSpecified = true;
                _passcodeMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayMessagesMenuKeys _playMessagesMenuKeys;

        [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayMessagesMenuKeys PlayMessagesMenuKeys
        {
            get => _playMessagesMenuKeys;
            set
            {
                PlayMessagesMenuKeysSpecified = true;
                _playMessagesMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMessagesMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayMessageMenuKeys _playMessageMenuKeys;

        [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayMessageMenuKeys PlayMessageMenuKeys
        {
            get => _playMessageMenuKeys;
            set
            {
                PlayMessageMenuKeysSpecified = true;
                _playMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMessageMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19AdditionalMessageOptionsMenuKeys _additionalMessageOptionsMenuKeys;

        [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys
        {
            get => _additionalMessageOptionsMenuKeys;
            set
            {
                AdditionalMessageOptionsMenuKeysSpecified = true;
                _additionalMessageOptionsMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool AdditionalMessageOptionsMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ForwardOrComposeMessageMenuKeys _forwardOrComposeMessageMenuKeys;

        [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys
        {
            get => _forwardOrComposeMessageMenuKeys;
            set
            {
                ForwardOrComposeMessageMenuKeysSpecified = true;
                _forwardOrComposeMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardOrComposeMessageMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReplyMessageMenuKeys _replyMessageMenuKeys;

        [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReplyMessageMenuKeys ReplyMessageMenuKeys
        {
            get => _replyMessageMenuKeys;
            set
            {
                ReplyMessageMenuKeysSpecified = true;
                _replyMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ReplyMessageMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToDistributionListMenuKeys _sendToDistributionListMenuKeys;

        [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToDistributionListMenuKeys SendToDistributionListMenuKeys
        {
            get => _sendToDistributionListMenuKeys;
            set
            {
                SendToDistributionListMenuKeysSpecified = true;
                _sendToDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendToDistributionListMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SelectDistributionListMenuKeys _selectDistributionListMenuKeys;

        [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SelectDistributionListMenuKeys SelectDistributionListMenuKeys
        {
            get => _selectDistributionListMenuKeys;
            set
            {
                SelectDistributionListMenuKeysSpecified = true;
                _selectDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SelectDistributionListMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReviewSelectedDistributionListMenuKeys _reviewSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys
        {
            get => _reviewSelectedDistributionListMenuKeys;
            set
            {
                ReviewSelectedDistributionListMenuKeysSpecified = true;
                _reviewSelectedDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ReviewSelectedDistributionListMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendMessageToSelectedDistributionListMenuKeys _sendMessageToSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys
        {
            get => _sendMessageToSelectedDistributionListMenuKeys;
            set
            {
                SendMessageToSelectedDistributionListMenuKeysSpecified = true;
                _sendMessageToSelectedDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendMessageToSelectedDistributionListMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToAllGroupMembersMenuKeys _sendToAllGroupMembersMenuKeys;

        [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys
        {
            get => _sendToAllGroupMembersMenuKeys;
            set
            {
                SendToAllGroupMembersMenuKeysSpecified = true;
                _sendToAllGroupMembersMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendToAllGroupMembersMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToPersonMenuKeys _sendToPersonMenuKeys;

        [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToPersonMenuKeys SendToPersonMenuKeys
        {
            get => _sendToPersonMenuKeys;
            set
            {
                SendToPersonMenuKeysSpecified = true;
                _sendToPersonMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendToPersonMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeCurrentIntroductionOrMessageOrReplyMenuKeys _changeCurrentIntroductionOrMessageOrReplyMenuKeys;

        [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys
        {
            get => _changeCurrentIntroductionOrMessageOrReplyMenuKeys;
            set
            {
                ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified = true;
                _changeCurrentIntroductionOrMessageOrReplyMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalLoginMenuKeys _voicePortalLoginMenuKeys;

        [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys
        {
            get => _voicePortalLoginMenuKeys;
            set
            {
                VoicePortalLoginMenuKeysSpecified = true;
                _voicePortalLoginMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalLoginMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19FaxMessagingMenuKeys _faxMessagingMenuKeys;

        [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19FaxMessagingMenuKeys FaxMessagingMenuKeys
        {
            get => _faxMessagingMenuKeys;
            set
            {
                FaxMessagingMenuKeysSpecified = true;
                _faxMessagingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool FaxMessagingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19MessageDepositMenuKeys _messageDepositMenuKeys;

        [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19MessageDepositMenuKeys MessageDepositMenuKeys
        {
            get => _messageDepositMenuKeys;
            set
            {
                MessageDepositMenuKeysSpecified = true;
                _messageDepositMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool MessageDepositMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19DisableMessageDepositMenuKeys _disableMessageDepositMenuKeys;

        [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys
        {
            get => _disableMessageDepositMenuKeys;
            set
            {
                DisableMessageDepositMenuKeysSpecified = true;
                _disableMessageDepositMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool DisableMessageDepositMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingOnlyForwardingDestinationMenuKeys _greetingOnlyForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37440")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys
        {
            get => _greetingOnlyForwardingDestinationMenuKeys;
            set
            {
                GreetingOnlyForwardingDestinationMenuKeysSpecified = true;
                _greetingOnlyForwardingDestinationMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool GreetingOnlyForwardingDestinationMenuKeysSpecified { get; set; }

    }
}
