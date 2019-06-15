using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider's password rules setting applicable to
    /// Administrators (Group and Department) and Users.
    /// The response is either ServiceProviderPasswordRulesGetResponse16 or ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderPasswordRulesGetRequest22 in AS data mode.
        /// <see cref="ServiceProviderPasswordRulesGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderPasswordRulesGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderPasswordRulesGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
    }
}
