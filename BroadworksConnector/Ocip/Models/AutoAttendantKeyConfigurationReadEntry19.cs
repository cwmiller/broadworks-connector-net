using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The read configuration entry of a key for Auto
    /// Attendant.
    /// The following data elements are only
    /// used in AS data
    /// mode:
    /// audioFileDescription
    /// audioMediaType
    /// videoFileDescription
    /// videoMediaType
    /// submenuId
    /// The following
    /// data elements are only valid for Standard Auto
    /// Attendants:
    /// submenuId
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AutoAttendantKeyConfigurationReadEntry19 
    {

        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AutoAttendantKeyAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantKeyAction Action {
            get => _action;
            set {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }
        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
        private string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        public string AudioFileDescription {
            get => _audioFileDescription;
            set {
                AudioFileDescriptionSpecified = true;
                _audioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileDescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioMediaType {
            get => _audioMediaType;
            set {
                AudioMediaTypeSpecified = true;
                _audioMediaType = value;
            }
        }

        [XmlIgnore]
        public bool AudioMediaTypeSpecified { get; set; }
        
        private string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        public string VideoFileDescription {
            get => _videoFileDescription;
            set {
                VideoFileDescriptionSpecified = true;
                _videoFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileDescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VideoMediaType {
            get => _videoMediaType;
            set {
                VideoMediaTypeSpecified = true;
                _videoMediaType = value;
            }
        }

        [XmlIgnore]
        public bool VideoMediaTypeSpecified { get; set; }
        
        private string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = false, Namespace = "")]
        public string SubmenuId {
            get => _submenuId;
            set {
                SubmenuIdSpecified = true;
                _submenuId = value;
            }
        }

        [XmlIgnore]
        public bool SubmenuIdSpecified { get; set; }
        
    }
}
