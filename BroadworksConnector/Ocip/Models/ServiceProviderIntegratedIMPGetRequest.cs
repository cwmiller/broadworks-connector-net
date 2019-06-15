using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Integrated IMP service attributes for the service provider.
    /// The response is either ServiceProviderIntegratedIMPGetResponse or ErrorResponse.
    /// Replaced by: ServiceProviderIntegratedIMPGetRequest21 in AS data mode
        /// <see cref="ServiceProviderIntegratedIMPGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderIntegratedIMPGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderIntegratedIMPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
