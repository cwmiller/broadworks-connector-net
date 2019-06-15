using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Advice of Charge service provider parameters.
    /// The response is either ServiceProviderAdviceOfChargeGetResponse or ErrorResponse.
        /// <see cref="ServiceProviderAdviceOfChargeGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAdviceOfChargeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
