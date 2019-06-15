using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of users for a file repository in the system.
    /// The response is either a SystemFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// <see cref="SystemFileRepositoryDeviceUserGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFileRepositoryDeviceUserGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _fileRepositoryName;

        [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
        public string FileRepositoryName {
            get => _fileRepositoryName;
            set {
                FileRepositoryNameSpecified = true;
                _fileRepositoryName = value;
            }
        }

        [XmlIgnore]
        public bool FileRepositoryNameSpecified { get; set; }
        
    }
}
