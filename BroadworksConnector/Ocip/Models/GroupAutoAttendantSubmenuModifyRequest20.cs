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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:620""}]")]
    public class GroupAutoAttendantSubmenuModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        protected string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool SubmenuIdSpecified { get; set; }

        protected string _newSubmenuId;

        [XmlElement(ElementName = "newSubmenuId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool NewSubmenuIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool AnnouncementSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool AudioFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool VideoFileSpecified { get; set; }

        protected bool _enableLevelExtensionDialing;

        [XmlElement(ElementName = "enableLevelExtensionDialing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool EnableLevelExtensionDialingSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration20> _keyConfiguration = new List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration20>();

        [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:620")]
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
        protected bool KeyConfigurationSpecified { get; set; }

    }
}
