using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify an Auto Attendant submenu instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// This request is only valid for Standard auto attendants.
    /// 
    /// Replaced by: GroupAutoAttendantSubmenuModifyRequest20 in AS data mode
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupAutoAttendantSubmenuModifyRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAutoAttendantSubmenuModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
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
        
        private string _newSubmenuId;

        [XmlElement(ElementName = "newSubmenuId", IsNullable = false, Namespace = "")]
        public string NewSubmenuId {
            get => _newSubmenuId;
            set {
                NewSubmenuIdSpecified = true;
                _newSubmenuId = value;
            }
        }

        [XmlIgnore]
        public bool NewSubmenuIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection {
            get => _announcementSelection;
            set {
                AnnouncementSelectionSpecified = true;
                _announcementSelection = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AudioFile {
            get => _audioFile;
            set {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource VideoFile {
            get => _videoFile;
            set {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileSpecified { get; set; }
        
        private bool _enableLevelExtensionDialing;

        [XmlElement(ElementName = "enableLevelExtensionDialing", IsNullable = false, Namespace = "")]
        public bool EnableLevelExtensionDialing {
            get => _enableLevelExtensionDialing;
            set {
                EnableLevelExtensionDialingSpecified = true;
                _enableLevelExtensionDialing = value;
            }
        }

        [XmlIgnore]
        public bool EnableLevelExtensionDialingSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration> _keyConfiguration;

        [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration> KeyConfiguration {
            get => _keyConfiguration;
            set {
                KeyConfigurationSpecified = true;
                _keyConfiguration = value;
            }
        }

        [XmlIgnore]
        public bool KeyConfigurationSpecified { get; set; }
        
    }
}
