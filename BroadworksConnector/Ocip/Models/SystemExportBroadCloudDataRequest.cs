using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to export all users that have BroadCloud services, such as
    /// user profile information and BroadCloud services related information for that user
    /// to a file so they can be uploaded to a Messaging Server/BroadCloud.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExportBroadCloudDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
