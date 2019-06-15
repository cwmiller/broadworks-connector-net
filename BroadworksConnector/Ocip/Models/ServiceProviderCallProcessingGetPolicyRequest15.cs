using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the service provider level data associated with Call Processing
    /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse15 or an ErrorResponse.
    /// Replaced By: ServiceProviderCallProcessingGetPolicyRequest16
        /// <see cref="ServiceProviderCallProcessingGetPolicyResponse15"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderCallProcessingGetPolicyRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCallProcessingGetPolicyRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
