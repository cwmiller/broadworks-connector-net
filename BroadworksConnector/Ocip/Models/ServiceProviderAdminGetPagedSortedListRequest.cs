using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of service provider administrators.
    /// The response is either a ServiceProviderAdminGetPagedSortedListResponse or an ErrorResponse.
    /// If no sortOrder is included, the response is sorted by Administrator ID ascending by default.
    /// If the responsePagingControl element is not provided, the paging startIndex will be
    /// set to 1 by default, and the responsePageSize will be set to the maximum
    /// responsePageSize by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
    /// included. Then the search criteria are logically ORed together.
    /// <see cref="ServiceProviderAdminGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:948""}]")]
    public class ServiceProviderAdminGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
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
        public bool ResponsePagingControlSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderAdminGetPagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderAdminGetPagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderServiceProviderAdminGetPagedSortedList> SortOrder
        {
            get => _sortOrder;
            set
            {
                SortOrderSpecified = true;
                _sortOrder = value;
            }
        }

        [XmlIgnore]
        public bool SortOrderSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminId> _searchCriteriaAdminId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminId>();

        [XmlElement(ElementName = "searchCriteriaAdminId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminId> SearchCriteriaAdminId
        {
            get => _searchCriteriaAdminId;
            set
            {
                SearchCriteriaAdminIdSpecified = true;
                _searchCriteriaAdminId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAdminIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminLastName> _searchCriteriaAdminLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminLastName>();

        [XmlElement(ElementName = "searchCriteriaAdminLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminLastName> SearchCriteriaAdminLastName
        {
            get => _searchCriteriaAdminLastName;
            set
            {
                SearchCriteriaAdminLastNameSpecified = true;
                _searchCriteriaAdminLastName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAdminLastNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminFirstName> _searchCriteriaAdminFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminFirstName>();

        [XmlElement(ElementName = "searchCriteriaAdminFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminFirstName> SearchCriteriaAdminFirstName
        {
            get => _searchCriteriaAdminFirstName;
            set
            {
                SearchCriteriaAdminFirstNameSpecified = true;
                _searchCriteriaAdminFirstName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAdminFirstNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactServiceProviderAdminType> _searchCriteriaExactServiceProviderAdminType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactServiceProviderAdminType>();

        [XmlElement(ElementName = "searchCriteriaExactServiceProviderAdminType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactServiceProviderAdminType> SearchCriteriaExactServiceProviderAdminType
        {
            get => _searchCriteriaExactServiceProviderAdminType;
            set
            {
                SearchCriteriaExactServiceProviderAdminTypeSpecified = true;
                _searchCriteriaExactServiceProviderAdminType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactServiceProviderAdminTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaLanguage> _searchCriteriaLanguage = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLanguage>();

        [XmlElement(ElementName = "searchCriteriaLanguage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaLanguage> SearchCriteriaLanguage
        {
            get => _searchCriteriaLanguage;
            set
            {
                SearchCriteriaLanguageSpecified = true;
                _searchCriteriaLanguage = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaLanguageSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:948")]
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
        public bool SearchCriteriaModeOrSpecified { get; set; }

    }
}
