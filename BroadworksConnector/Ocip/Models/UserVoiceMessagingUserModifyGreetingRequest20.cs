using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's voice messaging greeting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// The following elements are only used in AS data mode:
    /// disableMessageDeposit
    /// disableMessageDepositAction
    /// greetingOnlyForwardDestination
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:2026""}]")]
    public class UserVoiceMessagingUserModifyGreetingRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementSelection _busyAnnouncementSelection;

        [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _busyPersonalAudioFile;

        [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _busyPersonalVideoFile;

        [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection _noAnswerAnnouncementSelection;

        [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _noAnswerPersonalAudioFile;

        [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _noAnswerPersonalVideoFile;

        [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 _noAnswerAlternateGreeting01;

        [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 _noAnswerAlternateGreeting02;

        [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 _noAnswerAlternateGreeting03;

        [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected bool _extendedAwayEnabled;

        [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected bool _extendedAwayDisableMessageDeposit;

        [XmlElement(ElementName = "extendedAwayDisableMessageDeposit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _extendedAwayAudioFile;

        [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _extendedAwayVideoFile;

        [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingNumberOfRings _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected bool _disableMessageDeposit;

        [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection _disableMessageDepositAction;

        [XmlElement(ElementName = "disableMessageDepositAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

        protected string _greetingOnlyForwardDestination;

        [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2026")]
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

    }
}
