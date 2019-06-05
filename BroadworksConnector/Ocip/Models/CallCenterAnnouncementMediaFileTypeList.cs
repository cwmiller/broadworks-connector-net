using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterAnnouncementMediaFileTypeList
    {
        private BroadworksConnector.Ocip.Models.MediaFileType _mediaType1;

        [XmlElement(ElementName = "mediaType1", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType MediaType1
        {
            get => _mediaType1;
            set
            {
                MediaType1Specified = true;
                _mediaType1 = value;
            }
        }

        [XmlIgnore]
        public bool MediaType1Specified { get; set; }
        private BroadworksConnector.Ocip.Models.MediaFileType _mediaType2;

        [XmlElement(ElementName = "mediaType2", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType MediaType2
        {
            get => _mediaType2;
            set
            {
                MediaType2Specified = true;
                _mediaType2 = value;
            }
        }

        [XmlIgnore]
        public bool MediaType2Specified { get; set; }
        private BroadworksConnector.Ocip.Models.MediaFileType _mediaType3;

        [XmlElement(ElementName = "mediaType3", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType MediaType3
        {
            get => _mediaType3;
            set
            {
                MediaType3Specified = true;
                _mediaType3 = value;
            }
        }

        [XmlIgnore]
        public bool MediaType3Specified { get; set; }
        private BroadworksConnector.Ocip.Models.MediaFileType _mediaType4;

        [XmlElement(ElementName = "mediaType4", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.MediaFileType MediaType4
        {
            get => _mediaType4;
            set
            {
                MediaType4Specified = true;
                _mediaType4 = value;
            }
        }

        [XmlIgnore]
        public bool MediaType4Specified { get; set; }
    }
}
