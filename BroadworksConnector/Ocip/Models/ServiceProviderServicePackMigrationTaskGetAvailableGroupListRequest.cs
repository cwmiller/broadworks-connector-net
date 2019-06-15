using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a list of groups to migrate.
    /// The response is either ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse
    /// or ErrorResponse.
        /// <see cref="ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
            get => _searchCriteriaGroupId;
            set {
                SearchCriteriaGroupIdSpecified = true;
                _searchCriteriaGroupId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName> _searchCriteriaGroupName;

        [XmlElement(ElementName = "searchCriteriaGroupName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName> SearchCriteriaGroupName {
            get => _searchCriteriaGroupName;
            set {
                SearchCriteriaGroupNameSpecified = true;
                _searchCriteriaGroupName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupNameSpecified { get; set; }
        
    }
}
