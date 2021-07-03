using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVoiceMessagingGroupGetVoicePortalMenusRequest18sp1.
    /// 
    /// Replaced by SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusRequest18sp1"/>
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37055""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useVoicePortalCustomization;

        [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalMainMenuKeys _voicePortalMainMenuKeys;

        [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalMainMenuKeys VoicePortalMainMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoiceMessagingMenuKeys _voiceMessagingMenuKeys;

        [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoiceMessagingMenuKeys VoiceMessagingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PlayGreetingMenuKeys _playGreetingMenuKeys;

        [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PlayGreetingMenuKeys PlayGreetingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeBusyOrNoAnswerGreetingMenuKeys _changeBusyOrNoAnswerGreetingMenuKeys;

        [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeExtendedAwayGreetingMenuKeys _changeExtendedAwayGreetingMenuKeys;

        [XmlElement(ElementName = "changeExtendedAwayGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeExtendedAwayGreetingMenuKeys ChangeExtendedAwayGreetingMenuKeys
        {
            get => _changeExtendedAwayGreetingMenuKeys;
            set
            {
                ChangeExtendedAwayGreetingMenuKeysSpecified = true;
                _changeExtendedAwayGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeExtendedAwayGreetingMenuKeysSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1RecordNewGreetingOrPersonalizedNameMenuKeys _recordNewGreetingOrPersonalizedNameMenuKeys;

        [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1DeleteAllMessagesMenuKeys _deleteAllMessagesMenuKeys;

        [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1CommPilotExpressProfileMenuKeys _commPilotExpressProfileMenuKeys;

        [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PersonalizedNameMenuKeys _personalizedNameMenuKeys;

        [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PersonalizedNameMenuKeys PersonalizedNameMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1CallForwardingOptionsMenuKeys _callForwardingOptionsMenuKeys;

        [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeCallForwardingDestinationMenuKeys _changeCallForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalCallingMenuKeys _voicePortalCallingMenuKeys;

        [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1HotelingMenuKeys _hotelingMenuKeys;

        [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1HotelingMenuKeys HotelingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PasscodeMenuKeys _passcodeMenuKeys;

        [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PasscodeMenuKeys PasscodeMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PlayMessagesMenuKeys _playMessagesMenuKeys;

        [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PlayMessagesMenuKeys PlayMessagesMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PlayMessageMenuKeys _playMessageMenuKeys;

        [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PlayMessageMenuKeys PlayMessageMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1AdditionalMessageOptionsMenuKeys _additionalMessageOptionsMenuKeys;

        [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ForwardOrComposeMessageMenuKeys _forwardOrComposeMessageMenuKeys;

        [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ReplyMessageMenuKeys _replyMessageMenuKeys;

        [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ReplyMessageMenuKeys ReplyMessageMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToDistributionListMenuKeys _sendToDistributionListMenuKeys;

        [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToDistributionListMenuKeys SendToDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SelectDistributionListMenuKeys _selectDistributionListMenuKeys;

        [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SelectDistributionListMenuKeys SelectDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ReviewSelectedDistributionListMenuKeys _reviewSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendMessageToSelectedDistributionListMenuKeys _sendMessageToSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToAllGroupMembersMenuKeys _sendToAllGroupMembersMenuKeys;

        [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToPersonMenuKeys _sendToPersonMenuKeys;

        [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToPersonMenuKeys SendToPersonMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeCurrentIntroductionOrMessageOrReplyMenuKeys _changeCurrentIntroductionOrMessageOrReplyMenuKeys;

        [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalLoginMenuKeys _voicePortalLoginMenuKeys;

        [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1FaxMessagingMenuKeys _faxMessagingMenuKeys;

        [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1FaxMessagingMenuKeys FaxMessagingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1MessageDepositMenuKeys _messageDepositMenuKeys;

        [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1MessageDepositMenuKeys MessageDepositMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1DisableMessageDepositMenuKeys _disableMessageDepositMenuKeys;

        [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1GreetingOnlyForwardingDestinationMenuKeys _greetingOnlyForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37055")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys
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
