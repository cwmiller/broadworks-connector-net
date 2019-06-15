using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of available number ranges not yet assigned to any group.
    /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// <see cref="ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
