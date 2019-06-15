using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get an enterprise trunk
    /// The response is either an EnterpriseEnterpriseTrunkGetResponse or an ErrorResponse.
    /// Replaced by: EnterpriseEnterpriseTrunkGetRequest21
        /// <see cref="EnterpriseEnterpriseTrunkGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="EnterpriseEnterpriseTrunkGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseEnterpriseTrunkGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
        public string EnterpriseTrunkName {
            get => _enterpriseTrunkName;
            set {
                EnterpriseTrunkNameSpecified = true;
                _enterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkNameSpecified { get; set; }
        
    }
}
