using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterComfortMessageBypassGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        private int _callWaitingAgeThresholdSeconds;

        [XmlElement(ElementName = "callWaitingAgeThresholdSeconds", IsNullable = false, Namespace = "")]
        public int CallWaitingAgeThresholdSeconds
        {
            get => _callWaitingAgeThresholdSeconds;
            set
            {
                CallWaitingAgeThresholdSecondsSpecified = true;
                _callWaitingAgeThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingAgeThresholdSecondsSpecified { get; set; }
        private bool _playAnnouncementAfterRinging;

        [XmlElement(ElementName = "playAnnouncementAfterRinging", IsNullable = false, Namespace = "")]
        public bool PlayAnnouncementAfterRinging
        {
            get => _playAnnouncementAfterRinging;
            set
            {
                PlayAnnouncementAfterRingingSpecified = true;
                _playAnnouncementAfterRinging = value;
            }
        }

        [XmlIgnore]
        public bool PlayAnnouncementAfterRingingSpecified { get; set; }
        private int _ringTimeBeforePlayingAnnouncementSeconds;

        [XmlElement(ElementName = "ringTimeBeforePlayingAnnouncementSeconds", IsNullable = false, Namespace = "")]
        public int RingTimeBeforePlayingAnnouncementSeconds
        {
            get => _ringTimeBeforePlayingAnnouncementSeconds;
            set
            {
                RingTimeBeforePlayingAnnouncementSecondsSpecified = true;
                _ringTimeBeforePlayingAnnouncementSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RingTimeBeforePlayingAnnouncementSecondsSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection
        {
            get => _audioMessageSelection;
            set
            {
                AudioMessageSelectionSpecified = true;
                _audioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool AudioMessageSelectionSpecified { get; set; }
        private string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
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
        public bool AudioFileUrlSpecified { get; set; }
        private string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
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
        public bool AudioFileDescriptionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType AudioMediaType
        {
            get => _audioMediaType;
            set
            {
                AudioMediaTypeSpecified = true;
                _audioMediaType = value;
            }
        }

        [XmlIgnore]
        public bool AudioMediaTypeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection
        {
            get => _videoMessageSelection;
            set
            {
                VideoMessageSelectionSpecified = true;
                _videoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool VideoMessageSelectionSpecified { get; set; }
        private string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
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
        public bool VideoFileUrlSpecified { get; set; }
        private string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
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
        public bool VideoFileDescriptionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType VideoMediaType
        {
            get => _videoMediaType;
            set
            {
                VideoMediaTypeSpecified = true;
                _videoMediaType = value;
            }
        }

        [XmlIgnore]
        public bool VideoMediaTypeSpecified { get; set; }
    }
}
