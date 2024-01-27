using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the call center media on hold source configuration.
    /// 
    /// Replaced by: CallCenterMediaOnHoldSourceRead19.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:48579""}]")]
    public class CallCenterMediaOnHoldSourceRead17
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _audioMessageSourceSelection;

        [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection
        {
            get => _audioMessageSourceSelection;
            set
            {
                AudioMessageSourceSelectionSpecified = true;
                _audioMessageSourceSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMessageSourceSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalAudioSource;

        [XmlElement(ElementName = "externalAudioSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalAudioSource
        {
            get => _externalAudioSource;
            set
            {
                ExternalAudioSourceSpecified = true;
                _externalAudioSource = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalAudioSourceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _videoMessageSourceSelection;

        [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection
        {
            get => _videoMessageSourceSelection;
            set
            {
                VideoMessageSourceSelectionSpecified = true;
                _videoMessageSourceSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMessageSourceSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalVideoSource;

        [XmlElement(ElementName = "externalVideoSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48579")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalVideoSource
        {
            get => _externalVideoSource;
            set
            {
                ExternalVideoSourceSpecified = true;
                _externalVideoSource = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalVideoSourceSpecified { get; set; }

    }
}
