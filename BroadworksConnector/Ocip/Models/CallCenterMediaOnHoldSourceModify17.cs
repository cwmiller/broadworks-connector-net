using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterMediaOnHoldSourceModify17
    {
        private BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _audioMessageSourceSelection;

        [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection
        {
            get => _audioMessageSourceSelection;
            set
            {
                AudioMessageSourceSelectionSpecified = true;
                _audioMessageSourceSelection = value;
            }
        }

        [XmlIgnore]
        public bool AudioMessageSourceSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify AudioUrlList
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
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify AudioFileList
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
        private BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify _externalAudioSource;

        [XmlElement(ElementName = "externalAudioSource", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalAudioSource
        {
            get => _externalAudioSource;
            set
            {
                ExternalAudioSourceSpecified = true;
                _externalAudioSource = value;
            }
        }

        [XmlIgnore]
        public bool ExternalAudioSourceSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _videoMessageSourceSelection;

        [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection
        {
            get => _videoMessageSourceSelection;
            set
            {
                VideoMessageSourceSelectionSpecified = true;
                _videoMessageSourceSelection = value;
            }
        }

        [XmlIgnore]
        public bool VideoMessageSourceSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify VideoUrlList
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
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify VideoFileList
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
        private BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify _externalVideoSource;

        [XmlElement(ElementName = "externalVideoSource", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalVideoSource
        {
            get => _externalVideoSource;
            set
            {
                ExternalVideoSourceSpecified = true;
                _externalVideoSource = value;
            }
        }

        [XmlIgnore]
        public bool ExternalVideoSourceSpecified { get; set; }
    }
}
