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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:489""}]")]
    public class AnnouncementFileLevelKey
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:489")]
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
        public bool NameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _mediaFileType;

        [XmlElement(ElementName = "mediaFileType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:489")]
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
        public bool MediaFileTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementRepositoryType _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:489")]
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
        public bool LevelSpecified { get; set; }

    }
}
