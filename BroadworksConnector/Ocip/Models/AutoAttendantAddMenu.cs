using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The configuration of the automated receptionist greeting
    /// prompt and dialing menu to be used during after business hours.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:43394""}]")]
    public class AutoAttendantAddMenu
    {

        private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43394")]
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

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43394")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource AudioFile
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

        private BroadWorksConnector.Ocip.Models.LabeledFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43394")]
        public BroadWorksConnector.Ocip.Models.LabeledFileResource VideoFile
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

        private bool _enableFirstMenuLevelExtensionDialing;

        [XmlElement(ElementName = "enableFirstMenuLevelExtensionDialing", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43394")]
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
        protected bool EnableFirstMenuLevelExtensionDialingSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfiguration> _keyConfiguration = new List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfiguration>();

        [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43394")]
        public List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfiguration> KeyConfiguration
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
