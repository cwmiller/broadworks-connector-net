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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47671""}]")]
    public class CallCenterMediaOnHoldSourceRead16
    {

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _audioMessageSourceSelection;

        [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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

        private string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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

        private string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _audioFileMediaType;

        [XmlElement(ElementName = "audioFileMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioFileMediaType
        {
            get => _audioFileMediaType;
            set
            {
                AudioFileMediaTypeSpecified = true;
                _audioFileMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalAudioSource;

        [XmlElement(ElementName = "externalAudioSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _videoMessageSourceSelection;

        [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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

        private string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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

        private string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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

        private BroadWorksConnector.Ocip.Models.MediaFileType _videoFileMediaType;

        [XmlElement(ElementName = "videoFileMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VideoFileMediaType
        {
            get => _videoFileMediaType;
            set
            {
                VideoFileMediaTypeSpecified = true;
                _videoFileMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileMediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalVideoSource;

        [XmlElement(ElementName = "externalVideoSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47671")]
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
