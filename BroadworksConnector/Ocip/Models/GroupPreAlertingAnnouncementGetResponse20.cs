using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a GroupPreAlertingAnnouncementGetResponse20.
    /// <see cref="GroupPreAlertingAnnouncementGetResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6165f2b4cd549de71fe8f3171488fdd8:130""}]")]
    public class GroupPreAlertingAnnouncementGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.PreAlertingAnnouncementInterrupt _announcementInterruption;

        [XmlElement(ElementName = "announcementInterruption", IsNullable = false, Namespace = "")]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        public BroadWorksConnector.Ocip.Models.PreAlertingAnnouncementInterrupt AnnouncementInterruption
        {
            get => _announcementInterruption;
            set
            {
                AnnouncementInterruptionSpecified = true;
                _announcementInterruption = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementInterruptionSpecified { get; set; }

        protected string _interruptionDigitSequence;

        [XmlElement(ElementName = "interruptionDigitSequence", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        [MinLength(1)]
        [MaxLength(10)]
        public string InterruptionDigitSequence
        {
            get => _interruptionDigitSequence;
            set
            {
                InterruptionDigitSequenceSpecified = true;
                _interruptionDigitSequence = value;
            }
        }

        [XmlIgnore]
        protected bool InterruptionDigitSequenceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection
        {
            get => _audioSelection;
            set
            {
                AudioSelectionSpecified = true;
                _audioSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AudioSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileKey _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileSpecified { get; set; }

        protected string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileUrl
        {
            get => _audioFileUrl;
            set
            {
                AudioFileUrlSpecified = true;
                _audioFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileUrlSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection
        {
            get => _videoSelection;
            set
            {
                VideoSelectionSpecified = true;
                _videoSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VideoSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileKey _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileSpecified { get; set; }

        protected string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6165f2b4cd549de71fe8f3171488fdd8:130")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileUrl
        {
            get => _videoFileUrl;
            set
            {
                VideoFileUrlSpecified = true;
                _videoFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileUrlSpecified { get; set; }

    }
}
