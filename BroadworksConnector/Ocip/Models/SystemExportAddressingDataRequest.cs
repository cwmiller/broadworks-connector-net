using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to export Application Server addressing data, such as DNs, extensions, alias and user ids
    /// to a file so they can be uploaded to a Network Server.
    /// In XS data mode, response is sent without waiting for completion.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExportAddressingDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _fileName;

        [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
        public string FileName {
            get => _fileName;
            set {
                FileNameSpecified = true;
                _fileName = value;
            }
        }

        [XmlIgnore]
        public bool FileNameSpecified { get; set; }
        
    }
}
