using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains list of file media types for audio or video files
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:880""}]")]
    public class CallCenterAnnouncementMediaFileTypeList
    {

        private BroadWorksConnector.Ocip.Models.MediaFileType _mediaType1;

        [XmlElement(ElementName = "mediaType1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:880")]
        public BroadWorksConnector.Ocip.Models.MediaFileType MediaType1
        {
            get => _mediaType1;
            set
            {
                MediaType1Specified = true;
                _mediaType1 = value;
            }
        }

        [XmlIgnore]
        protected bool MediaType1Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _mediaType2;

        [XmlElement(ElementName = "mediaType2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:880")]
        public BroadWorksConnector.Ocip.Models.MediaFileType MediaType2
        {
            get => _mediaType2;
            set
            {
                MediaType2Specified = true;
                _mediaType2 = value;
            }
        }

        [XmlIgnore]
        protected bool MediaType2Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _mediaType3;

        [XmlElement(ElementName = "mediaType3", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:880")]
        public BroadWorksConnector.Ocip.Models.MediaFileType MediaType3
        {
            get => _mediaType3;
            set
            {
                MediaType3Specified = true;
                _mediaType3 = value;
            }
        }

        [XmlIgnore]
        protected bool MediaType3Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _mediaType4;

        [XmlElement(ElementName = "mediaType4", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:880")]
        public BroadWorksConnector.Ocip.Models.MediaFileType MediaType4
        {
            get => _mediaType4;
            set
            {
                MediaType4Specified = true;
                _mediaType4 = value;
            }
        }

        [XmlIgnore]
        protected bool MediaType4Specified { get; set; }

    }
}
