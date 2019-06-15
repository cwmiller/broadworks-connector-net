using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of number prefixes that are assigned to an enterprise and still available for assignment to users within the enterprise.
    /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// <see cref="EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
