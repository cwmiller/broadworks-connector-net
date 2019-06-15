using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the profile for a service provider or enterprise.
    /// The response is either a ServiceProviderGetResponse13mp2 or an ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderGetRequest17sp1
        /// <see cref="ServiceProviderGetResponse13mp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderGetRequest17sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderGetRequest13mp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
