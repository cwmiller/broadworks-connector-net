using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemFileGetContentRequest. The fileContent length returned is limited to 128KBytes.
        /// <see cref="SystemFileGetContentRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileGetContentResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
