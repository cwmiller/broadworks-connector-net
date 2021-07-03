using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserVoiceMessagingUserGetGreetingRequest16.
    /// Contains the greeting configuration for a user's voice messaging.
    /// 
    /// Replaced by: UserVoiceMessagingUserGetGreetingResponse18
    /// <see cref="UserVoiceMessagingUserGetGreetingRequest16"/>
    /// <see cref="UserVoiceMessagingUserGetGreetingResponse18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47056""}]")]
    public class UserVoiceMessagingUserGetGreetingResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _busyAnnouncementSelection;

        [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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

        private BroadWorksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead16 _noAnswerAlternateGreeting01;

        [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47056")]
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

    }
}
