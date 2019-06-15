using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents either an existing file for the application server to use, or
    /// the contents of a file to transfer with a description.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class LabeledFileResource 
    {

        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
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
        
        private string _content;

        [XmlElement(ElementName = "content", IsNullable = false, Namespace = "")]
        public string Content {
            get => _content;
            set {
                ContentSpecified = true;
                _content = value;
            }
        }

        [XmlIgnore]
        public bool ContentSpecified { get; set; }
        
    }
}
