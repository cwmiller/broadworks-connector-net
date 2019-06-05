using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AnnouncementFileKey
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
    }
}
