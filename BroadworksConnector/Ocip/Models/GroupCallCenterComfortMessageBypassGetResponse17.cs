using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterComfortMessageBypassGetRequest17.
    /// 
    /// Replaced by: GroupCallCenterComfortMessageBypassGetResponse20
    /// <see cref="GroupCallCenterComfortMessageBypassGetRequest17"/>
    /// <see cref="GroupCallCenterComfortMessageBypassGetResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:4868""}]")]
    public class GroupCallCenterComfortMessageBypassGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList
        {
            get => _audioUrlList;
            set
            {
                AudioUrlListSpecified = true;
                _audioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList AudioFileList
        {
            get => _audioFileList;
            set
            {
                AudioFileListSpecified = true;
                _audioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _audioMediaTypeList;

        [XmlElement(ElementName = "audioMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList AudioMediaTypeList
        {
            get => _audioMediaTypeList;
            set
            {
                AudioMediaTypeListSpecified = true;
                _audioMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMediaTypeListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList
        {
            get => _videoUrlList;
            set
            {
                VideoUrlListSpecified = true;
                _videoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList VideoFileList
        {
            get => _videoFileList;
            set
            {
                VideoFileListSpecified = true;
                _videoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _videoMediaTypeList;

        [XmlElement(ElementName = "videoMediaTypeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:4868")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList VideoMediaTypeList
        {
            get => _videoMediaTypeList;
            set
            {
                VideoMediaTypeListSpecified = true;
                _videoMediaTypeList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMediaTypeListSpecified { get; set; }

    }
}
