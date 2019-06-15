using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a list of all service pack migration task for a service provider.
    /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse
    /// or ErrorResponse.
    /// 
    /// Replaced By: ServiceProviderServicePackMigrationTaskGetListRequest21 in AS data mode
        /// <see cref="ServiceProviderServicePackMigrationTaskGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderServicePackMigrationTaskGetListRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackMigrationTaskGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
