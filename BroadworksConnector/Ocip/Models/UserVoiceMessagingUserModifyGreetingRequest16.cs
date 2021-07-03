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
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// disableMessageDeposit
    /// disableMessageDepositAction
    /// greetingOnlyForwardDestination
    /// 
    /// Replaced by UserVoiceMessagingUserModifyGreetingRequest20 in AS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserVoiceMessagingUserModifyGreetingRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8b2edcd7d6936a8b76653949ae59623:526""}]")]
    public class UserVoiceMessagingUserModifyGreetingRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _busyAnnouncementSelection;

        [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _busyPersonalAudioFile;

        [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource BusyPersonalAudioFile
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _busyPersonalVideoFile;

        [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource BusyPersonalVideoFile
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _noAnswerPersonalAudioFile;

        [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource NoAnswerPersonalAudioFile
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _noAnswerPersonalVideoFile;

        [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource NoAnswerPersonalVideoFile
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

        private bool _extendedAwayEnabled;

        [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _extendedAwayAudioFile;

        [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource ExtendedAwayAudioFile
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _extendedAwayVideoFile;

        [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource ExtendedAwayVideoFile
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 _noAnswerAlternateGreeting01;

        [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting01
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 _noAnswerAlternateGreeting02;

        [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting02
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 _noAnswerAlternateGreeting03;

        [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting03
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingNumberOfRings _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:526")]
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
