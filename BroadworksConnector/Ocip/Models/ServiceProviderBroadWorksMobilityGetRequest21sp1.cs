using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider BroadWorks Mobility service settings.
    /// The response is either a ServiceProviderBroadWorksMobilityGetResponse21sp1 or an ErrorResponse.
    /// 
    /// Replaced by ServiceProviderBroadWorksMobilityGetRequest22V2.
        /// <see cref="ServiceProviderBroadWorksMobilityGetResponse21sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderBroadWorksMobilityGetRequest22V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderBroadWorksMobilityGetRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
