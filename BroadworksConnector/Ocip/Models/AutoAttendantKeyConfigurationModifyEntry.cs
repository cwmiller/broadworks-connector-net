using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AutoAttendantKeyConfigurationModifyEntry
    {
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AutoAttendantKeyAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantKeyAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.LabeledMediaFileResource VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileSpecified { get; set; }
        private string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = true, Namespace = "")]
        public string SubmenuId
        {
            get => _submenuId;
            set
            {
                SubmenuIdSpecified = true;
                _submenuId = value;
            }
        }

        [XmlIgnore]
        public bool SubmenuIdSpecified { get; set; }
    }
}
