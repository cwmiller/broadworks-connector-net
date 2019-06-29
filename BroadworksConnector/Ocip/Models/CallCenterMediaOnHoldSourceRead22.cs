using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the call center media on hold source configuration.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:958""}]")]
    public class CallCenterMediaOnHoldSourceRead22
    {

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _audioMessageSourceSelection;

        [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList
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

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 _externalAudioSource;

        [XmlElement(ElementName = "externalAudioSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 ExternalAudioSource
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

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _videoMessageSourceSelection;

        [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList
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

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 _externalVideoSource;

        [XmlElement(ElementName = "externalVideoSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:958")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 ExternalVideoSource
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
