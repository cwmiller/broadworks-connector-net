using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of feature access codes for a service provider or enterprise.
    /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse or an ErrorResponse.
    /// 
    /// Replaced By : ServiceProviderFeatureAccessCodeGetListRequest20 in AS data mode
        /// <see cref="ServiceProviderFeatureAccessCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderFeatureAccessCodeGetListRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderFeatureAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
