using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The modify configuration entry of a key for Auto
    /// Attendant.
    /// The following data elements are only valid for Standard Auto
    /// Attendants:
    /// submenuId
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:760""}]")]
    public class AutoAttendantKeyConfigurationModifyEntry
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:760")]
        [MinLength(1)]
        [MaxLength(20)]
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
        protected bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AutoAttendantKeyAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:760")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantKeyAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        protected bool ActionSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:760")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool PhoneNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:760")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AudioFile
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:760")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource VideoFile
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

        private string _submenuId;

        [XmlElement(ElementName = "submenuId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:760")]
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

    }
}
