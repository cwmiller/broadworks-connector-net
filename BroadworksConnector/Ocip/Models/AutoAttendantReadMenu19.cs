using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AutoAttendantReadMenu19
    {
        private BroadworksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection
        {
            get => _announcementSelection;
            set
            {
                AnnouncementSelectionSpecified = true;
                _announcementSelection = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementSelectionSpecified { get; set; }
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
        private bool _enableFirstMenuLevelExtensionDialing;

        [XmlElement(ElementName = "enableFirstMenuLevelExtensionDialing", IsNullable = false, Namespace = "")]
        public bool EnableFirstMenuLevelExtensionDialing
        {
            get => _enableFirstMenuLevelExtensionDialing;
            set
            {
                EnableFirstMenuLevelExtensionDialingSpecified = true;
                _enableFirstMenuLevelExtensionDialing = value;
            }
        }

        [XmlIgnore]
        public bool EnableFirstMenuLevelExtensionDialingSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.AutoAttendantKeyReadConfiguration19> _keyConfiguration;

        [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.AutoAttendantKeyReadConfiguration19> KeyConfiguration
        {
            get => _keyConfiguration;
            set
            {
                KeyConfigurationSpecified = true;
                _keyConfiguration = value;
            }
        }

        [XmlIgnore]
        public bool KeyConfigurationSpecified { get; set; }
    }
}
