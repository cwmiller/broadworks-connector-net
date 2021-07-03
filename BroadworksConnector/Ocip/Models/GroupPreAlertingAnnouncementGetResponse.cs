using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the group level pre-alerting service settings.
    /// The response is either a GroupPreAlertingAnnouncementGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupPreAlertingAnnouncementGetResponse20 in AS data mode
    /// <see cref="GroupPreAlertingAnnouncementGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupPreAlertingAnnouncementGetResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3712""}]")]
    public class GroupPreAlertingAnnouncementGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.PreAlertingAnnouncementInterrupt _announcementInterruption;

        [XmlElement(ElementName = "announcementInterruption", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
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

        private string _interruptionDigitSequence;

        [XmlElement(ElementName = "interruptionDigitSequence", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
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

        private string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileDescription
        {
            get => _audioFileDescription;
            set
            {
                AudioFileDescriptionSpecified = true;
                _audioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioMediaType
        {
            get => _audioMediaType;
            set
            {
                AudioMediaTypeSpecified = true;
                _audioMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMediaTypeSpecified { get; set; }

        private string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
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

        private string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileDescription
        {
            get => _videoFileDescription;
            set
            {
                VideoFileDescriptionSpecified = true;
                _videoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileDescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VideoMediaType
        {
            get => _videoMediaType;
            set
            {
                VideoMediaTypeSpecified = true;
                _videoMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMediaTypeSpecified { get; set; }

        private string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3712")]
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
