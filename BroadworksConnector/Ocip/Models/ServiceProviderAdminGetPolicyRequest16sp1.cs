using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider administrator's policy settings.
    /// The response is either ServiceProviderAdminGetPolicyResponse16sp1 or ErrorResponse.
    /// Replaced by: ServiceProviderAdminGetPolicyRequest17
        /// <see cref="ServiceProviderAdminGetPolicyResponse16sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderAdminGetPolicyRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAdminGetPolicyRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
    }
}
