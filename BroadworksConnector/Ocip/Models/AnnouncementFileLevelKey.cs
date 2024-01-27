using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies a file within a group or user repository.
    /// Includes level to distinguish between group and user announcements
    /// in scenarios where both are listed.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:615""}]")]
    public class AnnouncementFileLevelKey
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:615")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _mediaFileType;

        [XmlElement(ElementName = "mediaFileType", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:615")]
        public BroadWorksConnector.Ocip.Models.MediaFileType MediaFileType
        {
            get => _mediaFileType;
            set
            {
                MediaFileTypeSpecified = true;
                _mediaFileType = value;
            }
        }

        [XmlIgnore]
        protected bool MediaFileTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AnnouncementRepositoryType _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:615")]
        public BroadWorksConnector.Ocip.Models.AnnouncementRepositoryType Level
        {
            get => _level;
            set
            {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        protected bool LevelSpecified { get; set; }

    }
}
