using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterMediaOnHoldSourceRead16
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
        private BroadworksConnector.Ocip.Models.MediaFileType _audioFileMediaType;

        [XmlElement(ElementName = "audioFileMediaType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType AudioFileMediaType
        {
            get => _audioFileMediaType;
            set
            {
                AudioFileMediaTypeSpecified = true;
                _audioFileMediaType = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileMediaTypeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalAudioSource;

        [XmlElement(ElementName = "externalAudioSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalAudioSource
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
        private BroadworksConnector.Ocip.Models.MediaFileType _videoFileMediaType;

        [XmlElement(ElementName = "videoFileMediaType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType VideoFileMediaType
        {
            get => _videoFileMediaType;
            set
            {
                VideoFileMediaTypeSpecified = true;
                _videoFileMediaType = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileMediaTypeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalVideoSource;

        [XmlElement(ElementName = "externalVideoSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalVideoSource
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
