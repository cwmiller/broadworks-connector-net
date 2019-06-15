using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of service providers that have a given domain assigned.
    /// If resellerId is specified, only the service providers within the reseller should be returned.
    /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
    /// 
    /// The response is either SystemDomainGetAssignedServiceProviderListResponse or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// resellerId
        /// <see cref="SystemDomainGetAssignedServiceProviderListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDomainGetAssignedServiceProviderListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _domain;

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        public string Domain {
            get => _domain;
            set {
                DomainSpecified = true;
                _domain = value;
            }
        }

        [XmlIgnore]
        public bool DomainSpecified { get; set; }
        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
