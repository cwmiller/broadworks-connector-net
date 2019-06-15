using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of service providers and/or enterprises in the system.
    /// The response is either a ServiceProviderGetPagedSortedListResponse or an ErrorResponse.
    /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. Service providers/enterprise
    /// within the administrator's reseller meeting the search criteria are returned.
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
    /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
    /// If no sortOrder is included, the response is sorted by Service Provider Id ascending by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
    /// included. Then the search criteria are logically ORed together.
        /// <see cref="ServiceProviderGetPagedSortedListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl {
            get => _responsePagingControl;
            set {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        public bool ResponsePagingControlSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderGetPagedSortedList> _sortOrder;

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderGetPagedSortedList> SortOrder {
            get => _sortOrder;
            set {
                SortOrderSpecified = true;
                _sortOrder = value;
            }
        }

        [XmlIgnore]
        public bool SortOrderSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId;

        [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId {
            get => _searchCriteriaServiceProviderId;
            set {
                SearchCriteriaServiceProviderIdSpecified = true;
                _searchCriteriaServiceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaServiceProviderIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName> _searchCriteriaServiceProviderName;

        [XmlElement(ElementName = "searchCriteriaServiceProviderName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName> SearchCriteriaServiceProviderName {
            get => _searchCriteriaServiceProviderName;
            set {
                SearchCriteriaServiceProviderNameSpecified = true;
                _searchCriteriaServiceProviderName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaServiceProviderNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType _searchCriteriaExactOrganizationType;

        [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType {
            get => _searchCriteriaExactOrganizationType;
            set {
                SearchCriteriaExactOrganizationTypeSpecified = true;
                _searchCriteriaExactOrganizationType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactOrganizationTypeSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId;

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId {
            get => _searchCriteriaResellerId;
            set {
                SearchCriteriaResellerIdSpecified = true;
                _searchCriteriaResellerId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaResellerIdSpecified { get; set; }
        
        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        public bool SearchCriteriaModeOr {
            get => _searchCriteriaModeOr;
            set {
                SearchCriteriaModeOrSpecified = true;
                _searchCriteriaModeOr = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaModeOrSpecified { get; set; }
        
    }
}
