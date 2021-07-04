using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserVoiceMessagingUserGetGreetingRequest18sp1.
    /// Contains the greeting configuration for a user's voice messaging.
    /// The following elements are only used in AS data mode:
    /// disableMessageDeposit, value "false" is returned in XS data mode
    /// disableMessageDepositAction, value "Disconnect" is returned in XS data mode
    /// extendedAwayEnabled, value "false" is returned in XS data mode
    /// extendedAwayDisableMessageDeposit, value "true" is returned in XS data mode
    /// 
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// greetingOnlyForwardDestination
    /// extendedAwayAudioFile
    /// extendedAwayAudioMediaType
    /// extendedAwayVideoFile
    /// extendedAwayVideoMediaType
    /// 
    /// Replaced by: UserVoiceMessagingUserGetGreetingResponse20 in AS data mode
    /// <see cref="UserVoiceMessagingUserGetGreetingRequest18sp1"/>
    /// <see cref="UserVoiceMessagingUserGetGreetingResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8b2edcd7d6936a8b76653949ae59623:447""}]")]
    public class UserVoiceMessagingUserGetGreetingResponse18sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _busyAnnouncementSelection;

        [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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

        private string _busyPersonalAudioFile;

        [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        [MinLength(1)]
        [MaxLength(256)]
        public string BusyPersonalAudioFile
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _busyPersonalAudioMediaType;

        [XmlElement(ElementName = "busyPersonalAudioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.MediaFileType BusyPersonalAudioMediaType
        {
            get => _busyPersonalAudioMediaType;
            set
            {
                BusyPersonalAudioMediaTypeSpecified = true;
                _busyPersonalAudioMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool BusyPersonalAudioMediaTypeSpecified { get; set; }

        private string _busyPersonalVideoFile;

        [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        [MinLength(1)]
        [MaxLength(256)]
        public string BusyPersonalVideoFile
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _busyPersonalVideoMediaType;

        [XmlElement(ElementName = "busyPersonalVideoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.MediaFileType BusyPersonalVideoMediaType
        {
            get => _busyPersonalVideoMediaType;
            set
            {
                BusyPersonalVideoMediaTypeSpecified = true;
                _busyPersonalVideoMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool BusyPersonalVideoMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection _noAnswerAnnouncementSelection;

        [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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

        private string _noAnswerPersonalAudioFile;

        [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        [MinLength(1)]
        [MaxLength(256)]
        public string NoAnswerPersonalAudioFile
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _noAnswerPersonalAudioMediaType;

        [XmlElement(ElementName = "noAnswerPersonalAudioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.MediaFileType NoAnswerPersonalAudioMediaType
        {
            get => _noAnswerPersonalAudioMediaType;
            set
            {
                NoAnswerPersonalAudioMediaTypeSpecified = true;
                _noAnswerPersonalAudioMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerPersonalAudioMediaTypeSpecified { get; set; }

        private string _noAnswerPersonalVideoFile;

        [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        [MinLength(1)]
        [MaxLength(256)]
        public string NoAnswerPersonalVideoFile
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _noAnswerPersonalVideoMediaType;

        [XmlElement(ElementName = "noAnswerPersonalVideoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.MediaFileType NoAnswerPersonalVideoMediaType
        {
            get => _noAnswerPersonalVideoMediaType;
            set
            {
                NoAnswerPersonalVideoMediaTypeSpecified = true;
                _noAnswerPersonalVideoMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerPersonalVideoMediaTypeSpecified { get; set; }

        private bool _extendedAwayEnabled;

        [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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

        private string _extendedAwayAudioFile;

        [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ExtendedAwayAudioFile
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _extendedAwayAudioMediaType;

        [XmlElement(ElementName = "extendedAwayAudioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.MediaFileType ExtendedAwayAudioMediaType
        {
            get => _extendedAwayAudioMediaType;
            set
            {
                ExtendedAwayAudioMediaTypeSpecified = true;
                _extendedAwayAudioMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedAwayAudioMediaTypeSpecified { get; set; }

        private string _extendedAwayVideoFile;

        [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ExtendedAwayVideoFile
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _extendedAwayVideoMediaType;

        [XmlElement(ElementName = "extendedAwayVideoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.MediaFileType ExtendedAwayVideoMediaType
        {
            get => _extendedAwayVideoMediaType;
            set
            {
                ExtendedAwayVideoMediaTypeSpecified = true;
                _extendedAwayVideoMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedAwayVideoMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead16 _noAnswerAlternateGreeting01;

        [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead16 NoAnswerAlternateGreeting01
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead16 _noAnswerAlternateGreeting02;

        [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead16 NoAnswerAlternateGreeting02
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead16 _noAnswerAlternateGreeting03;

        [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead16 NoAnswerAlternateGreeting03
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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

        [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:447")]
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
