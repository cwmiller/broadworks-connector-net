using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the Service Provider level data associated with Dial Plan Policy.
    /// The response is either a ServiceProviderDialPlanPolicyGetResponse
    /// or an ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderDialPlanPolicyGetRequest17
        /// <see cref="ServiceProviderDialPlanPolicyGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderDialPlanPolicyGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderDialPlanPolicyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
