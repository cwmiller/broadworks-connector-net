using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterComfortMessageBypassGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList
        {
            get => _audioUrlList;
            set
            {
                AudioUrlListSpecified = true;
                _audioUrlList = value;
            }
        }

        [XmlIgnore]
        public bool AudioUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList
        {
            get => _audioFileList;
            set
            {
                AudioFileListSpecified = true;
                _audioFileList = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileListSpecified { get; set; }
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
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList
        {
            get => _videoUrlList;
            set
            {
                VideoUrlListSpecified = true;
                _videoUrlList = value;
            }
        }

        [XmlIgnore]
        public bool VideoUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList
        {
            get => _videoFileList;
            set
            {
                VideoFileListSpecified = true;
                _videoFileList = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileListSpecified { get; set; }
    }
}
