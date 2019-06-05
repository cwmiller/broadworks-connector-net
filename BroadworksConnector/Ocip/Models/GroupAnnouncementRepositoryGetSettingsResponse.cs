using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAnnouncementRepositoryGetSettingsResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private int _totalFileSize;

        [XmlElement(ElementName = "totalFileSize", IsNullable = false, Namespace = "")]
        public int TotalFileSize
        {
            get => _totalFileSize;
            set
            {
                TotalFileSizeSpecified = true;
                _totalFileSize = value;
            }
        }

        [XmlIgnore]
        public bool TotalFileSizeSpecified { get; set; }
        private int _maxAudioFileSize;

        [XmlElement(ElementName = "maxAudioFileSize", IsNullable = false, Namespace = "")]
        public int MaxAudioFileSize
        {
            get => _maxAudioFileSize;
            set
            {
                MaxAudioFileSizeSpecified = true;
                _maxAudioFileSize = value;
            }
        }

        [XmlIgnore]
        public bool MaxAudioFileSizeSpecified { get; set; }
        private int _maxVideoFileSize;

        [XmlElement(ElementName = "maxVideoFileSize", IsNullable = false, Namespace = "")]
        public int MaxVideoFileSize
        {
            get => _maxVideoFileSize;
            set
            {
                MaxVideoFileSizeSpecified = true;
                _maxVideoFileSize = value;
            }
        }

        [XmlIgnore]
        public bool MaxVideoFileSizeSpecified { get; set; }
        private int _maxFileSize;

        [XmlElement(ElementName = "maxFileSize", IsNullable = false, Namespace = "")]
        public int MaxFileSize
        {
            get => _maxFileSize;
            set
            {
                MaxFileSizeSpecified = true;
                _maxFileSize = value;
            }
        }

        [XmlIgnore]
        public bool MaxFileSizeSpecified { get; set; }
    }
}
