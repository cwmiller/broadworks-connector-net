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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1210""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _useVoicePortalCustomization;

        [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public bool? UseVoicePortalCustomization
        {
            get => _useVoicePortalCustomization;
            set
            {
                UseVoicePortalCustomizationSpecified = (value != null);
                _useVoicePortalCustomization = value;
            }
        }

        [XmlIgnore]
        protected bool UseVoicePortalCustomizationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalMainMenuKeys _voicePortalMainMenuKeys;

        [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalMainMenuKeys VoicePortalMainMenuKeys
        {
            get => _voicePortalMainMenuKeys;
            set
            {
                VoicePortalMainMenuKeysSpecified = (value != null);
                _voicePortalMainMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalMainMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementMenuKeys _announcementMenuKeys;

        [XmlElement(ElementName = "announcementMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementMenuKeys AnnouncementMenuKeys
        {
            get => _announcementMenuKeys;
            set
            {
                AnnouncementMenuKeysSpecified = (value != null);
                _announcementMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementRecordingMenuKeys _announcementRecordingMenuKeys;

        [XmlElement(ElementName = "announcementRecordingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementRecordingMenuKeys AnnouncementRecordingMenuKeys
        {
            get => _announcementRecordingMenuKeys;
            set
            {
                AnnouncementRecordingMenuKeysSpecified = (value != null);
                _announcementRecordingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementRecordingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingsMenuKeys _greetingsMenuKeys;

        [XmlElement(ElementName = "greetingsMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingsMenuKeys GreetingsMenuKeys
        {
            get => _greetingsMenuKeys;
            set
            {
                GreetingsMenuKeysSpecified = (value != null);
                _greetingsMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool GreetingsMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ConferenceGreetingMenuKeys _conferenceGreetingMenuKeys;

        [XmlElement(ElementName = "conferenceGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ConferenceGreetingMenuKeys ConferenceGreetingMenuKeys
        {
            get => _conferenceGreetingMenuKeys;
            set
            {
                ConferenceGreetingMenuKeysSpecified = (value != null);
                _conferenceGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceGreetingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoiceMessagingMenuKeys _voiceMessagingMenuKeys;

        [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoiceMessagingMenuKeys VoiceMessagingMenuKeys
        {
            get => _voiceMessagingMenuKeys;
            set
            {
                VoiceMessagingMenuKeysSpecified = (value != null);
                _voiceMessagingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayGreetingMenuKeys _playGreetingMenuKeys;

        [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayGreetingMenuKeys PlayGreetingMenuKeys
        {
            get => _playGreetingMenuKeys;
            set
            {
                PlayGreetingMenuKeysSpecified = (value != null);
                _playGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PlayGreetingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeBusyOrNoAnswerGreetingMenuKeys _changeBusyOrNoAnswerGreetingMenuKeys;

        [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys
        {
            get => _changeBusyOrNoAnswerGreetingMenuKeys;
            set
            {
                ChangeBusyOrNoAnswerGreetingMenuKeysSpecified = (value != null);
                _changeBusyOrNoAnswerGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeBusyOrNoAnswerGreetingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeExtendedAwayGreetingMenuKeys _changeExtendedAwayGreetingMenuKeys;

        [XmlElement(ElementName = "changeExtendedAwayGreetingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeExtendedAwayGreetingMenuKeys ChangeExtendedAwayGreetingMenuKeys
        {
            get => _changeExtendedAwayGreetingMenuKeys;
            set
            {
                ChangeExtendedAwayGreetingMenuKeysSpecified = (value != null);
                _changeExtendedAwayGreetingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeExtendedAwayGreetingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19RecordNewGreetingOrPersonalizedNameMenuKeys _recordNewGreetingOrPersonalizedNameMenuKeys;

        [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys
        {
            get => _recordNewGreetingOrPersonalizedNameMenuKeys;
            set
            {
                RecordNewGreetingOrPersonalizedNameMenuKeysSpecified = (value != null);
                _recordNewGreetingOrPersonalizedNameMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool RecordNewGreetingOrPersonalizedNameMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DeleteAllMessagesMenuKeys _deleteAllMessagesMenuKeys;

        [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys
        {
            get => _deleteAllMessagesMenuKeys;
            set
            {
                DeleteAllMessagesMenuKeysSpecified = (value != null);
                _deleteAllMessagesMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteAllMessagesMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CommPilotExpressProfileMenuKeys _commPilotExpressProfileMenuKeys;

        [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys
        {
            get => _commPilotExpressProfileMenuKeys;
            set
            {
                CommPilotExpressProfileMenuKeysSpecified = (value != null);
                _commPilotExpressProfileMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool CommPilotExpressProfileMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalizedNameMenuKeys _personalizedNameMenuKeys;

        [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalizedNameMenuKeys PersonalizedNameMenuKeys
        {
            get => _personalizedNameMenuKeys;
            set
            {
                PersonalizedNameMenuKeysSpecified = (value != null);
                _personalizedNameMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CallForwardingOptionsMenuKeys _callForwardingOptionsMenuKeys;

        [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys
        {
            get => _callForwardingOptionsMenuKeys;
            set
            {
                CallForwardingOptionsMenuKeysSpecified = (value != null);
                _callForwardingOptionsMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool CallForwardingOptionsMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCallForwardingDestinationMenuKeys _changeCallForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys
        {
            get => _changeCallForwardingDestinationMenuKeys;
            set
            {
                ChangeCallForwardingDestinationMenuKeysSpecified = (value != null);
                _changeCallForwardingDestinationMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCallForwardingDestinationMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalCallingMenuKeys _voicePortalCallingMenuKeys;

        [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys
        {
            get => _voicePortalCallingMenuKeys;
            set
            {
                VoicePortalCallingMenuKeysSpecified = (value != null);
                _voicePortalCallingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalCallingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19HotelingMenuKeys _hotelingMenuKeys;

        [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19HotelingMenuKeys HotelingMenuKeys
        {
            get => _hotelingMenuKeys;
            set
            {
                HotelingMenuKeysSpecified = (value != null);
                _hotelingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool HotelingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PasscodeMenuKeys _passcodeMenuKeys;

        [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PasscodeMenuKeys PasscodeMenuKeys
        {
            get => _passcodeMenuKeys;
            set
            {
                PasscodeMenuKeysSpecified = (value != null);
                _passcodeMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessagesMenuKeys _playMessagesMenuKeys;

        [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessagesMenuKeys PlayMessagesMenuKeys
        {
            get => _playMessagesMenuKeys;
            set
            {
                PlayMessagesMenuKeysSpecified = (value != null);
                _playMessagesMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMessagesMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessageMenuKeys _playMessageMenuKeys;

        [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessageMenuKeys PlayMessageMenuKeys
        {
            get => _playMessageMenuKeys;
            set
            {
                PlayMessageMenuKeysSpecified = (value != null);
                _playMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMessageMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AdditionalMessageOptionsMenuKeys _additionalMessageOptionsMenuKeys;

        [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys
        {
            get => _additionalMessageOptionsMenuKeys;
            set
            {
                AdditionalMessageOptionsMenuKeysSpecified = (value != null);
                _additionalMessageOptionsMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool AdditionalMessageOptionsMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ForwardOrComposeMessageMenuKeys _forwardOrComposeMessageMenuKeys;

        [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys
        {
            get => _forwardOrComposeMessageMenuKeys;
            set
            {
                ForwardOrComposeMessageMenuKeysSpecified = (value != null);
                _forwardOrComposeMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardOrComposeMessageMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReplyMessageMenuKeys _replyMessageMenuKeys;

        [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReplyMessageMenuKeys ReplyMessageMenuKeys
        {
            get => _replyMessageMenuKeys;
            set
            {
                ReplyMessageMenuKeysSpecified = (value != null);
                _replyMessageMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ReplyMessageMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToDistributionListMenuKeys _sendToDistributionListMenuKeys;

        [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToDistributionListMenuKeys SendToDistributionListMenuKeys
        {
            get => _sendToDistributionListMenuKeys;
            set
            {
                SendToDistributionListMenuKeysSpecified = (value != null);
                _sendToDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendToDistributionListMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SelectDistributionListMenuKeys _selectDistributionListMenuKeys;

        [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SelectDistributionListMenuKeys SelectDistributionListMenuKeys
        {
            get => _selectDistributionListMenuKeys;
            set
            {
                SelectDistributionListMenuKeysSpecified = (value != null);
                _selectDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SelectDistributionListMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReviewSelectedDistributionListMenuKeys _reviewSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys
        {
            get => _reviewSelectedDistributionListMenuKeys;
            set
            {
                ReviewSelectedDistributionListMenuKeysSpecified = (value != null);
                _reviewSelectedDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ReviewSelectedDistributionListMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendMessageToSelectedDistributionListMenuKeys _sendMessageToSelectedDistributionListMenuKeys;

        [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys
        {
            get => _sendMessageToSelectedDistributionListMenuKeys;
            set
            {
                SendMessageToSelectedDistributionListMenuKeysSpecified = (value != null);
                _sendMessageToSelectedDistributionListMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendMessageToSelectedDistributionListMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToAllGroupMembersMenuKeys _sendToAllGroupMembersMenuKeys;

        [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys
        {
            get => _sendToAllGroupMembersMenuKeys;
            set
            {
                SendToAllGroupMembersMenuKeysSpecified = (value != null);
                _sendToAllGroupMembersMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendToAllGroupMembersMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToPersonMenuKeys _sendToPersonMenuKeys;

        [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToPersonMenuKeys SendToPersonMenuKeys
        {
            get => _sendToPersonMenuKeys;
            set
            {
                SendToPersonMenuKeysSpecified = (value != null);
                _sendToPersonMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool SendToPersonMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCurrentIntroductionOrMessageOrReplyMenuKeys _changeCurrentIntroductionOrMessageOrReplyMenuKeys;

        [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys
        {
            get => _changeCurrentIntroductionOrMessageOrReplyMenuKeys;
            set
            {
                ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified = (value != null);
                _changeCurrentIntroductionOrMessageOrReplyMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCurrentIntroductionOrMessageOrReplyMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalLoginMenuKeys _voicePortalLoginMenuKeys;

        [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys
        {
            get => _voicePortalLoginMenuKeys;
            set
            {
                VoicePortalLoginMenuKeysSpecified = (value != null);
                _voicePortalLoginMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalLoginMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19FaxMessagingMenuKeys _faxMessagingMenuKeys;

        [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19FaxMessagingMenuKeys FaxMessagingMenuKeys
        {
            get => _faxMessagingMenuKeys;
            set
            {
                FaxMessagingMenuKeysSpecified = (value != null);
                _faxMessagingMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool FaxMessagingMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19MessageDepositMenuKeys _messageDepositMenuKeys;

        [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19MessageDepositMenuKeys MessageDepositMenuKeys
        {
            get => _messageDepositMenuKeys;
            set
            {
                MessageDepositMenuKeysSpecified = (value != null);
                _messageDepositMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool MessageDepositMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DisableMessageDepositMenuKeys _disableMessageDepositMenuKeys;

        [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys
        {
            get => _disableMessageDepositMenuKeys;
            set
            {
                DisableMessageDepositMenuKeysSpecified = (value != null);
                _disableMessageDepositMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool DisableMessageDepositMenuKeysSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingOnlyForwardingDestinationMenuKeys _greetingOnlyForwardingDestinationMenuKeys;

        [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys
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

        protected BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalAssistantMenuKeys _personalAssistantMenuKeys;

        [XmlElement(ElementName = "personalAssistantMenuKeys", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1210")]
        public BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalAssistantMenuKeys PersonalAssistantMenuKeys
        {
            get => _personalAssistantMenuKeys;
            set
            {
                PersonalAssistantMenuKeysSpecified = (value != null);
                _personalAssistantMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalAssistantMenuKeysSpecified { get; set; }

    }
}
