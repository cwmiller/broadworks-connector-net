using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AnnouncementFileLevelKey
    {
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
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
        private BroadworksConnector.Ocip.Models.MediaFileType _mediaFileType;

        [XmlElement(ElementName = "mediaFileType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType MediaFileType
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
        private BroadworksConnector.Ocip.Models.AnnouncementRepositoryType _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementRepositoryType Level
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
