using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider BroadWorks Mobility service settings.
    /// The response is either a ServiceProviderBroadWorksMobilityGetResponse19sp1 or an ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderBroadWorksMobilityGetRequest22 in AS data mode
        /// <see cref="ServiceProviderBroadWorksMobilityGetResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderBroadWorksMobilityGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderBroadWorksMobilityGetRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
