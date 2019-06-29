using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents either an existing file for the application server to use, or
    /// the contents of a file to transfer.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2399"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2400""}]}]")]
    public class FileResource
    {

        private string _sourceFileName;

        [XmlElement(ElementName = "sourceFileName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2400")]
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
        protected bool SourceFileNameSpecified { get; set; }

        private string _fileContent;

        [XmlElement(ElementName = "fileContent", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2400")]
        public string FileContent
        {
            get => _fileContent;
            set
            {
                FileContentSpecified = true;
                _fileContent = value;
            }
        }

        [XmlIgnore]
        protected bool FileContentSpecified { get; set; }

    }
}
