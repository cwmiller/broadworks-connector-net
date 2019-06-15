using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents either an existing file for the application server to use, or
    /// the contents of a file to transfer.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class FileResource 
    {

        
        private string _sourceFileName;

        [XmlElement(ElementName = "sourceFileName", IsNullable = false, Namespace = "")]
        public string SourceFileName {
            get => _sourceFileName;
            set {
                SourceFileNameSpecified = true;
                _sourceFileName = value;
            }
        }

        [XmlIgnore]
        public bool SourceFileNameSpecified { get; set; }
        
        private string _fileContent;

        [XmlElement(ElementName = "fileContent", IsNullable = false, Namespace = "")]
        public string FileContent {
            get => _fileContent;
            set {
                FileContentSpecified = true;
                _fileContent = value;
            }
        }

        [XmlIgnore]
        public bool FileContentSpecified { get; set; }
        
    }
}
