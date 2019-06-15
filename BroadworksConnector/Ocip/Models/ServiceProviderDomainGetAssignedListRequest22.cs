using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all matching domains assigned to a service provider .
    /// The response is either ServiceProviderDomainGetAssignedListResponse22 or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and will be ignored in XS data mode:
    /// responseSizeLimit
    /// searchCriteriaDomainName
        /// <see cref="ServiceProviderDomainGetAssignedListResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderDomainGetAssignedListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        public int ResponseSizeLimit {
            get => _responseSizeLimit;
            set {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName> _searchCriteriaDomainName;

        [XmlElement(ElementName = "searchCriteriaDomainName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName> SearchCriteriaDomainName {
            get => _searchCriteriaDomainName;
            set {
                SearchCriteriaDomainNameSpecified = true;
                _searchCriteriaDomainName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDomainNameSpecified { get; set; }
        
    }
}
