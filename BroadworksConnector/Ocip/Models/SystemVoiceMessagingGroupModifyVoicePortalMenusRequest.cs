using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:38741""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private bool _useVoicePortalCustomization;

        [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalMainMenuKeys _voicePortalMainMenuKeys;

        [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalMainMenuKeys VoicePortalMainMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoiceMessagingMenuKeys _voiceMessagingMenuKeys;

        [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoiceMessagingMenuKeys VoiceMessagingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPlayGreetingMenuKeys _playGreetingMenuKeys;

        [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPlayGreetingMenuKeys PlayGreetingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeBusyOrNoAnswerGreetingMenuKeys _changeBusyOrNoAnswerGreetingMenuKeys;

        [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeExtendedAwayGreetingMenuKeys _changeExtendedAwayGreetingMenuKeys;

        [XmlElement(ElementName = "changeExtendedAwayGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeExtendedAwayGreetingMenuKeys ChangeExtendedAwayGreetingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestRecordNewGreetingOrPersonalizedNameMenuKeys _recordNewGreetingOrPersonalizedNameMenuKeys;

        [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestRecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestDeleteAllMessagesMenuKeys _deleteAllMessagesMenuKeys;

        [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestDeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestCommPilotExpressProfileMenuKeys _commPilotExpressProfileMenuKeys;

        [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestCommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPersonalizedNameMenuKeys _personalizedNameMenuKeys;

        [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPersonalizedNameMenuKeys PersonalizedNameMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestCallForwardingOptionsMenuKeys _callForwardingOptionsMenuKeys;

        [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestCallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeCallForwardingDestinationMenuKeys _changeCallForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalCallingMenuKeys _voicePortalCallingMenuKeys;

        [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalCallingMenuKeys VoicePortalCallingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestHotelingMenuKeys _hotelingMenuKeys;

        [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestHotelingMenuKeys HotelingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPasscodeMenuKeys _passcodeMenuKeys;

        [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPasscodeMenuKeys PasscodeMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPlayMessagesMenuKeys _playMessagesMenuKeys;

        [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPlayMessagesMenuKeys PlayMessagesMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPlayMessageMenuKeys _playMessageMenuKeys;

        [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPlayMessageMenuKeys PlayMessageMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestAdditionalMessageOptionsMenuKeys _additionalMessageOptionsMenuKeys;

        [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestAdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestForwardOrComposeMessageMenuKeys _forwardOrComposeMessageMenuKeys;

        [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestReplyMessageMenuKeys _replyMessageMenuKeys;

        [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestReplyMessageMenuKeys ReplyMessageMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToDistributionListMenuKeys _sendToDistributionListMenuKeys;

        [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToDistributionListMenuKeys SendToDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSelectDistributionListMenuKeys _selectDistributionListMenuKeys;

        [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSelectDistributionListMenuKeys SelectDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestReviewSelectedDistributionListMenuKeys _reviewSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendMessageToSelectedDistributionListMenuKeys _sendMessageToSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToAllGroupMembersMenuKeys _sendToAllGroupMembersMenuKeys;

        [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToPersonMenuKeys _sendToPersonMenuKeys;

        [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToPersonMenuKeys SendToPersonMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeCurrentIntroductionOrMessageOrReplyMenuKeys _changeCurrentIntroductionOrMessageOrReplyMenuKeys;

        [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalLoginMenuKeys _voicePortalLoginMenuKeys;

        [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalLoginMenuKeys VoicePortalLoginMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestFaxMessagingMenuKeys _faxMessagingMenuKeys;

        [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestFaxMessagingMenuKeys FaxMessagingMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestMessageDepositMenuKeys _messageDepositMenuKeys;

        [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestMessageDepositMenuKeys MessageDepositMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestDisableMessageDepositMenuKeys _disableMessageDepositMenuKeys;

        [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestDisableMessageDepositMenuKeys DisableMessageDepositMenuKeys
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

        private BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestGreetingOnlyForwardingDestinationMenuKeys _greetingOnlyForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38741")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequestGreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys
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
