using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains list of file descriptions for audio or video files
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:951""}]")]
    public class CallCenterAnnouncementDescriptionList
    {

        protected string _fileDescription1;

        [XmlElement(ElementName = "fileDescription1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:951")]
        [MinLength(1)]
        [MaxLength(256)]
        public string FileDescription1
        {
            get => _fileDescription1;
            set
            {
                FileDescription1Specified = true;
                _fileDescription1 = value;
            }
        }

        [XmlIgnore]
        protected bool FileDescription1Specified { get; set; }

        protected string _fileDescription2;

        [XmlElement(ElementName = "fileDescription2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:951")]
        [MinLength(1)]
        [MaxLength(256)]
        public string FileDescription2
        {
            get => _fileDescription2;
            set
            {
                FileDescription2Specified = true;
                _fileDescription2 = value;
            }
        }

        [XmlIgnore]
        protected bool FileDescription2Specified { get; set; }

        protected string _fileDescription3;

        [XmlElement(ElementName = "fileDescription3", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:951")]
        [MinLength(1)]
        [MaxLength(256)]
        public string FileDescription3
        {
            get => _fileDescription3;
            set
            {
                FileDescription3Specified = true;
                _fileDescription3 = value;
            }
        }

        [XmlIgnore]
        protected bool FileDescription3Specified { get; set; }

        protected string _fileDescription4;

        [XmlElement(ElementName = "fileDescription4", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:951")]
        [MinLength(1)]
        [MaxLength(256)]
        public string FileDescription4
        {
            get => _fileDescription4;
            set
            {
                FileDescription4Specified = true;
                _fileDescription4 = value;
            }
        }

        [XmlIgnore]
        protected bool FileDescription4Specified { get; set; }

    }
}
