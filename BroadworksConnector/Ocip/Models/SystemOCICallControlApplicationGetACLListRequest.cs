using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI call control access control list.
    /// The response is either SystemOCICallControlApplicationGetACLListResponse or ErrorResponse.
        /// <see cref="SystemOCICallControlApplicationGetACLListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCICallControlApplicationGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        public string ApplicationId {
            get => _applicationId;
            set {
                ApplicationIdSpecified = true;
                _applicationId = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationIdSpecified { get; set; }
        
    }
}
