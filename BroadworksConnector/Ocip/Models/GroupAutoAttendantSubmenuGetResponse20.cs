using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAutoAttendantSubmenuGetRequest20.
    /// Contains AutoAttendant submenu information.
    /// <see cref="GroupAutoAttendantSubmenuGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:557""}]")]
    public class GroupAutoAttendantSubmenuGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:557")]
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

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:557")]
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

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:557")]
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
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:557")]
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

        protected List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyReadConfiguration20> _keyConfiguration = new List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyReadConfiguration20>();

        [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:557")]
        public List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyReadConfiguration20> KeyConfiguration
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
