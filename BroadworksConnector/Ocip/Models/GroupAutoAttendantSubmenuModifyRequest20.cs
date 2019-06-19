using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify an Auto Attendant submenu instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// This request is only valid for Standard auto attendants.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ed0640d8ef49eb8b4eaa14d7c6f6c033:596""}]")]
    public class GroupAutoAttendantSubmenuModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = false, Namespace = "")]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        [MinLength(1)]
        [MaxLength(40)]
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

        private string _newSubmenuId;

        [XmlElement(ElementName = "newSubmenuId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewSubmenuId
        {
            get => _newSubmenuId;
            set
            {
                NewSubmenuIdSpecified = true;
                _newSubmenuId = value;
            }
        }

        [XmlIgnore]
        public bool NewSubmenuIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        public BroadWorksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection
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

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile
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

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile
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

        private bool _enableLevelExtensionDialing;

        [XmlElement(ElementName = "enableLevelExtensionDialing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        public bool EnableLevelExtensionDialing
        {
            get => _enableLevelExtensionDialing;
            set
            {
                EnableLevelExtensionDialingSpecified = true;
                _enableLevelExtensionDialing = value;
            }
        }

        [XmlIgnore]
        public bool EnableLevelExtensionDialingSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration20> _keyConfiguration = new List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration20>();

        [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ed0640d8ef49eb8b4eaa14d7c6f6c033:596")]
        public List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration20> KeyConfiguration
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
