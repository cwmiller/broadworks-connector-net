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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:824""}]")]
    public class CallCenterAnnouncementDescriptionList
    {

        private string _fileDescription1;

        [XmlElement(ElementName = "fileDescription1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:824")]
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
        public bool FileDescription1Specified { get; set; }

        private string _fileDescription2;

        [XmlElement(ElementName = "fileDescription2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:824")]
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
        public bool FileDescription2Specified { get; set; }

        private string _fileDescription3;

        [XmlElement(ElementName = "fileDescription3", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:824")]
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
        public bool FileDescription3Specified { get; set; }

        private string _fileDescription4;

        [XmlElement(ElementName = "fileDescription4", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:824")]
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
        public bool FileDescription4Specified { get; set; }

    }
}
