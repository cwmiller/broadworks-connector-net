using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4502""}]")]
    public class ServiceProviderGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderGetPagedSortedListResponse>
    {

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4502")]
        public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl
        {
            get => _responsePagingControl;
            set
            {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        protected bool ResponsePagingControlSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderGetPagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderGetPagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4502")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderGetPagedSortedList> SortOrder
        {
            get => _sortOrder;
            set
            {
                SortOrderSpecified = true;
                _sortOrder = value;
            }
        }

        [XmlIgnore]
        protected bool SortOrderSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4502")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId
        {
            get => _searchCriteriaServiceProviderId;
            set
            {
                SearchCriteriaServiceProviderIdSpecified = true;
                _searchCriteriaServiceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceProviderIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName> _searchCriteriaServiceProviderName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4502")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName> SearchCriteriaServiceProviderName
        {
            get => _searchCriteriaServiceProviderName;
            set
            {
                SearchCriteriaServiceProviderNameSpecified = true;
                _searchCriteriaServiceProviderName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceProviderNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType _searchCriteriaExactOrganizationType;

        [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4502")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType
        {
            get => _searchCriteriaExactOrganizationType;
            set
            {
                SearchCriteriaExactOrganizationTypeSpecified = true;
                _searchCriteriaExactOrganizationType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactOrganizationTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId>();

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4502")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId
        {
            get => _searchCriteriaResellerId;
            set
            {
                SearchCriteriaResellerIdSpecified = true;
                _searchCriteriaResellerId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaResellerIdSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4502")]
        public bool SearchCriteriaModeOr
        {
            get => _searchCriteriaModeOr;
            set
            {
                SearchCriteriaModeOrSpecified = true;
                _searchCriteriaModeOr = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaModeOrSpecified { get; set; }

    }
}
