using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's voice messaging advanced voice management service setting.
    /// Modify a voice mail distribution list for a users voice message.
    /// Modify the user's voice messaging greeting.
    /// Modify the user's voice messaging outgoing message waiting indicator service setting.
    /// Modify the user's voice messaging voice portal settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2075"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2081"",""optional"":true}]}]")]
    public class UserVoiceMessagingUserModifyRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection _mailServerSelection;

        [XmlElement(ElementName = "mailServerSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection MailServerSelection
        {
            get => _mailServerSelection;
            set
            {
                MailServerSelectionSpecified = true;
                _mailServerSelection = value;
            }
        }

        [XmlIgnore]
        protected bool MailServerSelectionSpecified { get; set; }

        private string _groupMailServerEmailAddress;

        [XmlElement(ElementName = "groupMailServerEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GroupMailServerEmailAddress
        {
            get => _groupMailServerEmailAddress;
            set
            {
                GroupMailServerEmailAddressSpecified = true;
                _groupMailServerEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool GroupMailServerEmailAddressSpecified { get; set; }

        private string _groupMailServerUserId;

        [XmlElement(ElementName = "groupMailServerUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GroupMailServerUserId
        {
            get => _groupMailServerUserId;
            set
            {
                GroupMailServerUserIdSpecified = true;
                _groupMailServerUserId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupMailServerUserIdSpecified { get; set; }

        private string _groupMailServerPassword;

        [XmlElement(ElementName = "groupMailServerPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(60)]
        public string GroupMailServerPassword
        {
            get => _groupMailServerPassword;
            set
            {
                GroupMailServerPasswordSpecified = true;
                _groupMailServerPassword = value;
            }
        }

        [XmlIgnore]
        protected bool GroupMailServerPasswordSpecified { get; set; }

        private bool _useGroupDefaultMailServerFullMailboxLimit;

        [XmlElement(ElementName = "useGroupDefaultMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2081")]
        public bool UseGroupDefaultMailServerFullMailboxLimit
        {
            get => _useGroupDefaultMailServerFullMailboxLimit;
            set
            {
                UseGroupDefaultMailServerFullMailboxLimitSpecified = true;
                _useGroupDefaultMailServerFullMailboxLimit = value;
            }
        }

        [XmlIgnore]
        protected bool UseGroupDefaultMailServerFullMailboxLimitSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _groupMailServerFullMailboxLimit;

        [XmlElement(ElementName = "groupMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2081")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes GroupMailServerFullMailboxLimit
        {
            get => _groupMailServerFullMailboxLimit;
            set
            {
                GroupMailServerFullMailboxLimitSpecified = true;
                _groupMailServerFullMailboxLimit = value;
            }
        }

        [XmlIgnore]
        protected bool GroupMailServerFullMailboxLimitSpecified { get; set; }

        private string _personalMailServerNetAddress;

        [XmlElement(ElementName = "personalMailServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PersonalMailServerNetAddress
        {
            get => _personalMailServerNetAddress;
            set
            {
                PersonalMailServerNetAddressSpecified = true;
                _personalMailServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalMailServerNetAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol _personalMailServerProtocol;

        [XmlElement(ElementName = "personalMailServerProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol PersonalMailServerProtocol
        {
            get => _personalMailServerProtocol;
            set
            {
                PersonalMailServerProtocolSpecified = true;
                _personalMailServerProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalMailServerProtocolSpecified { get; set; }

        private bool _personalMailServerRealDeleteForImap;

        [XmlElement(ElementName = "personalMailServerRealDeleteForImap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool PersonalMailServerRealDeleteForImap
        {
            get => _personalMailServerRealDeleteForImap;
            set
            {
                PersonalMailServerRealDeleteForImapSpecified = true;
                _personalMailServerRealDeleteForImap = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalMailServerRealDeleteForImapSpecified { get; set; }

        private string _personalMailServerEmailAddress;

        [XmlElement(ElementName = "personalMailServerEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PersonalMailServerEmailAddress
        {
            get => _personalMailServerEmailAddress;
            set
            {
                PersonalMailServerEmailAddressSpecified = true;
                _personalMailServerEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalMailServerEmailAddressSpecified { get; set; }

        private string _personalMailServerUserId;

        [XmlElement(ElementName = "personalMailServerUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PersonalMailServerUserId
        {
            get => _personalMailServerUserId;
            set
            {
                PersonalMailServerUserIdSpecified = true;
                _personalMailServerUserId = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalMailServerUserIdSpecified { get; set; }

        private string _personalMailServerPassword;

        [XmlElement(ElementName = "personalMailServerPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(60)]
        public string PersonalMailServerPassword
        {
            get => _personalMailServerPassword;
            set
            {
                PersonalMailServerPasswordSpecified = true;
                _personalMailServerPassword = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalMailServerPasswordSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.VoiceMessagingDistributionListModify> _voiceMessagingDistributionList = new List<BroadWorksConnector.Ocip.Models.VoiceMessagingDistributionListModify>();

        [XmlElement(ElementName = "voiceMessagingDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public List<BroadWorksConnector.Ocip.Models.VoiceMessagingDistributionListModify> VoiceMessagingDistributionList
        {
            get => _voiceMessagingDistributionList;
            set
            {
                VoiceMessagingDistributionListSpecified = true;
                _voiceMessagingDistributionList = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingDistributionListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _busyAnnouncementSelection;

        [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection
        {
            get => _busyAnnouncementSelection;
            set
            {
                BusyAnnouncementSelectionSpecified = true;
                _busyAnnouncementSelection = value;
            }
        }

        [XmlIgnore]
        protected bool BusyAnnouncementSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _busyPersonalAudioFile;

        [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey BusyPersonalAudioFile
        {
            get => _busyPersonalAudioFile;
            set
            {
                BusyPersonalAudioFileSpecified = true;
                _busyPersonalAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool BusyPersonalAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _busyPersonalVideoFile;

        [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey BusyPersonalVideoFile
        {
            get => _busyPersonalVideoFile;
            set
            {
                BusyPersonalVideoFileSpecified = true;
                _busyPersonalVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool BusyPersonalVideoFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection _noAnswerAnnouncementSelection;

        [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection
        {
            get => _noAnswerAnnouncementSelection;
            set
            {
                NoAnswerAnnouncementSelectionSpecified = true;
                _noAnswerAnnouncementSelection = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerAnnouncementSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _noAnswerPersonalAudioFile;

        [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey NoAnswerPersonalAudioFile
        {
            get => _noAnswerPersonalAudioFile;
            set
            {
                NoAnswerPersonalAudioFileSpecified = true;
                _noAnswerPersonalAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerPersonalAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _noAnswerPersonalVideoFile;

        [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey NoAnswerPersonalVideoFile
        {
            get => _noAnswerPersonalVideoFile;
            set
            {
                NoAnswerPersonalVideoFileSpecified = true;
                _noAnswerPersonalVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerPersonalVideoFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 _noAnswerAlternateGreeting01;

        [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 NoAnswerAlternateGreeting01
        {
            get => _noAnswerAlternateGreeting01;
            set
            {
                NoAnswerAlternateGreeting01Specified = true;
                _noAnswerAlternateGreeting01 = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerAlternateGreeting01Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 _noAnswerAlternateGreeting02;

        [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 NoAnswerAlternateGreeting02
        {
            get => _noAnswerAlternateGreeting02;
            set
            {
                NoAnswerAlternateGreeting02Specified = true;
                _noAnswerAlternateGreeting02 = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerAlternateGreeting02Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 _noAnswerAlternateGreeting03;

        [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 NoAnswerAlternateGreeting03
        {
            get => _noAnswerAlternateGreeting03;
            set
            {
                NoAnswerAlternateGreeting03Specified = true;
                _noAnswerAlternateGreeting03 = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerAlternateGreeting03Specified { get; set; }

        private bool _extendedAwayEnabled;

        [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool ExtendedAwayEnabled
        {
            get => _extendedAwayEnabled;
            set
            {
                ExtendedAwayEnabledSpecified = true;
                _extendedAwayEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedAwayEnabledSpecified { get; set; }

        private bool _extendedAwayDisableMessageDeposit;

        [XmlElement(ElementName = "extendedAwayDisableMessageDeposit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool ExtendedAwayDisableMessageDeposit
        {
            get => _extendedAwayDisableMessageDeposit;
            set
            {
                ExtendedAwayDisableMessageDepositSpecified = true;
                _extendedAwayDisableMessageDeposit = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedAwayDisableMessageDepositSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _extendedAwayAudioFile;

        [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey ExtendedAwayAudioFile
        {
            get => _extendedAwayAudioFile;
            set
            {
                ExtendedAwayAudioFileSpecified = true;
                _extendedAwayAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedAwayAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _extendedAwayVideoFile;

        [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey ExtendedAwayVideoFile
        {
            get => _extendedAwayVideoFile;
            set
            {
                ExtendedAwayVideoFileSpecified = true;
                _extendedAwayVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedAwayVideoFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingNumberOfRings _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings
        {
            get => _noAnswerNumberOfRings;
            set
            {
                NoAnswerNumberOfRingsSpecified = true;
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerNumberOfRingsSpecified { get; set; }

        private bool _disableMessageDeposit;

        [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool DisableMessageDeposit
        {
            get => _disableMessageDeposit;
            set
            {
                DisableMessageDepositSpecified = true;
                _disableMessageDeposit = value;
            }
        }

        [XmlIgnore]
        protected bool DisableMessageDepositSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection _disableMessageDepositAction;

        [XmlElement(ElementName = "disableMessageDepositAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection DisableMessageDepositAction
        {
            get => _disableMessageDepositAction;
            set
            {
                DisableMessageDepositActionSpecified = true;
                _disableMessageDepositAction = value;
            }
        }

        [XmlIgnore]
        protected bool DisableMessageDepositActionSpecified { get; set; }

        private string _greetingOnlyForwardDestination;

        [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(161)]
        public string GreetingOnlyForwardDestination
        {
            get => _greetingOnlyForwardDestination;
            set
            {
                GreetingOnlyForwardDestinationSpecified = true;
                _greetingOnlyForwardDestination = value;
            }
        }

        [XmlIgnore]
        protected bool GreetingOnlyForwardDestinationSpecified { get; set; }

        private bool _outgoingSMDIMWIisActive;

        [XmlElement(ElementName = "outgoingSMDIMWIisActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool OutgoingSMDIMWIisActive
        {
            get => _outgoingSMDIMWIisActive;
            set
            {
                OutgoingSMDIMWIisActiveSpecified = true;
                _outgoingSMDIMWIisActive = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingSMDIMWIisActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNList _outgoingSMDIMWIPhoneNumberList;

        [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNList OutgoingSMDIMWIPhoneNumberList
        {
            get => _outgoingSMDIMWIPhoneNumberList;
            set
            {
                OutgoingSMDIMWIPhoneNumberListSpecified = true;
                _outgoingSMDIMWIPhoneNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingSMDIMWIPhoneNumberListSpecified { get; set; }

        private bool _voiceManagementisActive;

        [XmlElement(ElementName = "voiceManagementisActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool VoiceManagementisActive
        {
            get => _voiceManagementisActive;
            set
            {
                VoiceManagementisActiveSpecified = true;
                _voiceManagementisActive = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceManagementisActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMessageProcessing _processing;

        [XmlElement(ElementName = "processing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMessageProcessing Processing
        {
            get => _processing;
            set
            {
                ProcessingSpecified = true;
                _processing = value;
            }
        }

        [XmlIgnore]
        protected bool ProcessingSpecified { get; set; }

        private string _voiceMessageDeliveryEmailAddress;

        [XmlElement(ElementName = "voiceMessageDeliveryEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageDeliveryEmailAddress
        {
            get => _voiceMessageDeliveryEmailAddress;
            set
            {
                VoiceMessageDeliveryEmailAddressSpecified = true;
                _voiceMessageDeliveryEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageDeliveryEmailAddressSpecified { get; set; }

        private bool _usePhoneMessageWaitingIndicator;

        [XmlElement(ElementName = "usePhoneMessageWaitingIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool UsePhoneMessageWaitingIndicator
        {
            get => _usePhoneMessageWaitingIndicator;
            set
            {
                UsePhoneMessageWaitingIndicatorSpecified = true;
                _usePhoneMessageWaitingIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool UsePhoneMessageWaitingIndicatorSpecified { get; set; }

        private bool _sendVoiceMessageNotifyEmail;

        [XmlElement(ElementName = "sendVoiceMessageNotifyEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool SendVoiceMessageNotifyEmail
        {
            get => _sendVoiceMessageNotifyEmail;
            set
            {
                SendVoiceMessageNotifyEmailSpecified = true;
                _sendVoiceMessageNotifyEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendVoiceMessageNotifyEmailSpecified { get; set; }

        private string _voiceMessageNotifyEmailAddress;

        [XmlElement(ElementName = "voiceMessageNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageNotifyEmailAddress
        {
            get => _voiceMessageNotifyEmailAddress;
            set
            {
                VoiceMessageNotifyEmailAddressSpecified = true;
                _voiceMessageNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageNotifyEmailAddressSpecified { get; set; }

        private bool _sendCarbonCopyVoiceMessage;

        [XmlElement(ElementName = "sendCarbonCopyVoiceMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool SendCarbonCopyVoiceMessage
        {
            get => _sendCarbonCopyVoiceMessage;
            set
            {
                SendCarbonCopyVoiceMessageSpecified = true;
                _sendCarbonCopyVoiceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool SendCarbonCopyVoiceMessageSpecified { get; set; }

        private string _voiceMessageCarbonCopyEmailAddress;

        [XmlElement(ElementName = "voiceMessageCarbonCopyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageCarbonCopyEmailAddress
        {
            get => _voiceMessageCarbonCopyEmailAddress;
            set
            {
                VoiceMessageCarbonCopyEmailAddressSpecified = true;
                _voiceMessageCarbonCopyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageCarbonCopyEmailAddressSpecified { get; set; }

        private bool _transferOnZeroToPhoneNumber;

        [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool TransferOnZeroToPhoneNumber
        {
            get => _transferOnZeroToPhoneNumber;
            set
            {
                TransferOnZeroToPhoneNumberSpecified = true;
                _transferOnZeroToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferOnZeroToPhoneNumberSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferPhoneNumberSpecified { get; set; }

        private bool _alwaysRedirectToVoiceMail;

        [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool AlwaysRedirectToVoiceMail
        {
            get => _alwaysRedirectToVoiceMail;
            set
            {
                AlwaysRedirectToVoiceMailSpecified = true;
                _alwaysRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysRedirectToVoiceMailSpecified { get; set; }

        private bool _busyRedirectToVoiceMail;

        [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool BusyRedirectToVoiceMail
        {
            get => _busyRedirectToVoiceMail;
            set
            {
                BusyRedirectToVoiceMailSpecified = true;
                _busyRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool BusyRedirectToVoiceMailSpecified { get; set; }

        private bool _noAnswerRedirectToVoiceMail;

        [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool NoAnswerRedirectToVoiceMail
        {
            get => _noAnswerRedirectToVoiceMail;
            set
            {
                NoAnswerRedirectToVoiceMailSpecified = true;
                _noAnswerRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerRedirectToVoiceMailSpecified { get; set; }

        private bool _outOfPrimaryZoneRedirectToVoiceMail;

        [XmlElement(ElementName = "outOfPrimaryZoneRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool OutOfPrimaryZoneRedirectToVoiceMail
        {
            get => _outOfPrimaryZoneRedirectToVoiceMail;
            set
            {
                OutOfPrimaryZoneRedirectToVoiceMailSpecified = true;
                _outOfPrimaryZoneRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool OutOfPrimaryZoneRedirectToVoiceMailSpecified { get; set; }

        private bool _usePersonalizedName;

        [XmlElement(ElementName = "usePersonalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool UsePersonalizedName
        {
            get => _usePersonalizedName;
            set
            {
                UsePersonalizedNameSpecified = true;
                _usePersonalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool UsePersonalizedNameSpecified { get; set; }

        private bool _voicePortalAutoLogin;

        [XmlElement(ElementName = "voicePortalAutoLogin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public bool VoicePortalAutoLogin
        {
            get => _voicePortalAutoLogin;
            set
            {
                VoicePortalAutoLoginSpecified = true;
                _voicePortalAutoLogin = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalAutoLoginSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _personalizedNameAudioFile;

        [XmlElement(ElementName = "personalizedNameAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey PersonalizedNameAudioFile
        {
            get => _personalizedNameAudioFile;
            set
            {
                PersonalizedNameAudioFileSpecified = true;
                _personalizedNameAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAliasReplacementList _userMessagingAliasList;

        [XmlElement(ElementName = "userMessagingAliasList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2075")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAliasReplacementList UserMessagingAliasList
        {
            get => _userMessagingAliasList;
            set
            {
                UserMessagingAliasListSpecified = true;
                _userMessagingAliasList = value;
            }
        }

        [XmlIgnore]
        protected bool UserMessagingAliasListSpecified { get; set; }

    }
}
