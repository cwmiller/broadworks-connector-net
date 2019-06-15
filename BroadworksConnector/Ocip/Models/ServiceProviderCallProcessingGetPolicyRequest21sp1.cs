using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the service provider level data associated with Call Processing
    /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse21sp1 or an ErrorResponse.
    /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest21sp2
        /// <see cref="ServiceProviderCallProcessingGetPolicyResponse21sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderCallProcessingGetPolicyRequest21sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCallProcessingGetPolicyRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
