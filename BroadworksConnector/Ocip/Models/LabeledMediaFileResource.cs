using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents either an existing file for the application server to use, or
    /// the contents of a file to transfer with a description.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2526"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2529""}]}]")]
    public class LabeledMediaFileResource
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2526")]
        [MinLength(1)]
        [MaxLength(256)]
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
        public bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _mediaType;

        [XmlElement(ElementName = "mediaType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2526")]
        public BroadWorksConnector.Ocip.Models.MediaFileType MediaType
        {
            get => _mediaType;
            set
            {
                MediaTypeSpecified = true;
                _mediaType = value;
            }
        }

        [XmlIgnore]
        public bool MediaTypeSpecified { get; set; }

        private string _sourceFileName;

        [XmlElement(ElementName = "sourceFileName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2529")]
        [MinLength(1)]
        public string SourceFileName
        {
            get => _sourceFileName;
            set
            {
                SourceFileNameSpecified = true;
                _sourceFileName = value;
            }
        }

        [XmlIgnore]
        public bool SourceFileNameSpecified { get; set; }

        private string _content;

        [XmlElement(ElementName = "content", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2529")]
        public string Content
        {
            get => _content;
            set
            {
                ContentSpecified = true;
                _content = value;
            }
        }

        [XmlIgnore]
        public bool ContentSpecified { get; set; }

    }
}
