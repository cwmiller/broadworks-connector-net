using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a call center's comfort message bypass settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:4895""}]")]
    public class GroupCallCenterComfortMessageBypassModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
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
        protected bool IsActiveSpecified { get; set; }

        protected int _callWaitingAgeThresholdSeconds;

        [XmlElement(ElementName = "callWaitingAgeThresholdSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
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
        protected bool CallWaitingAgeThresholdSecondsSpecified { get; set; }

        protected bool _playAnnouncementAfterRinging;

        [XmlElement(ElementName = "playAnnouncementAfterRinging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
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
        protected bool PlayAnnouncementAfterRingingSpecified { get; set; }

        protected int _ringTimeBeforePlayingAnnouncementSeconds;

        [XmlElement(ElementName = "ringTimeBeforePlayingAnnouncementSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
        [MinInclusive(0)]
        [MaxInclusive(120)]
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
        protected bool RingTimeBeforePlayingAnnouncementSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection
        {
            get => _audioMessageSelection;
            set
            {
                AudioMessageSelectionSpecified = true;
                _audioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection
        {
            get => _videoMessageSelection;
            set
            {
                VideoMessageSelectionSpecified = true;
                _videoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4895")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile
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

    }
}
