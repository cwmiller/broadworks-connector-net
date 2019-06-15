using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the contents of a file.  This transaction is only allowed to get content for files under
    /// /var/broadworks/userfiles/AuditLogs/ or /var/broadworks/IpDeviceConfig/.
    /// The response is either a SystemFileGetContentResponse or an ErrorResponse.
        /// <see cref="SystemFileGetContentResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileGetContentRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
