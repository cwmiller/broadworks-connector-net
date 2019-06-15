using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider BroadWorks Mobility service settings.
    /// The response is either a ServiceProviderBroadWorksMobilityGetResponse or an ErrorResponse.
    /// Replaced by: ServiceProviderBroadWorksMobilityGetRequest19sp1
        /// <see cref="ServiceProviderBroadWorksMobilityGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderBroadWorksMobilityGetRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderBroadWorksMobilityGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
