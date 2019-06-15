using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a service provider or enterprise's answer confirmation settings.
    /// The response is either a ServiceProviderAnswerConfirmationGetResponse or an ErrorResponse.
    /// Replaced By: ServiceProviderAnswerConfirmationGetRequest16
        /// <see cref="ServiceProviderAnswerConfirmationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderAnswerConfirmationGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAnswerConfirmationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
