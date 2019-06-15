using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Integrated IMP service attributes for the service provider.
    /// The response is either ServiceProviderIntegratedIMPGetResponse21 or ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderIntegratedIMPGetRequest21sp1 in AS data mode
        /// <see cref="ServiceProviderIntegratedIMPGetResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderIntegratedIMPGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderIntegratedIMPGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
