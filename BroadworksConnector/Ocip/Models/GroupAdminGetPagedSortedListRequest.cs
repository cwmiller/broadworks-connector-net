using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of group and department administrators within the group.
    /// The response is either a GroupAdminGetPagedSortedListResponse or an ErrorResponse.
    /// If no sort criterion is included, the response is sorted by administrator id ascending by default.
    /// If the responsePagingControl element is not provided, the paging startIndex will be
    /// set to 1 by default, and the responsePageSize will be set to the maximum
    /// responsePageSize by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
    /// included. Then the search criteria are logically ORed together.
    /// <see cref="GroupAdminGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1564""}]")]
    public class GroupAdminGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupAdminGetPagedSortedListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
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

        protected List<BroadWorksConnector.Ocip.Models.SortOrderGroupAdminGetPagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderGroupAdminGetPagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderGroupAdminGetPagedSortedList> SortOrder
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminId> _searchCriteriaAdminId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminId>();

        [XmlElement(ElementName = "searchCriteriaAdminId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
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
        protected bool SearchCriteriaAdminIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminLastName> _searchCriteriaAdminLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminLastName>();

        [XmlElement(ElementName = "searchCriteriaAdminLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
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
        protected bool SearchCriteriaAdminLastNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminFirstName> _searchCriteriaAdminFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAdminFirstName>();

        [XmlElement(ElementName = "searchCriteriaAdminFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
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
        protected bool SearchCriteriaAdminFirstNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactGroupAdminType> _searchCriteriaExactGroupAdminType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactGroupAdminType>();

        [XmlElement(ElementName = "searchCriteriaExactGroupAdminType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactGroupAdminType> SearchCriteriaExactGroupAdminType
        {
            get => _searchCriteriaExactGroupAdminType;
            set
            {
                SearchCriteriaExactGroupAdminTypeSpecified = true;
                _searchCriteriaExactGroupAdminType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactGroupAdminTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaLanguage> _searchCriteriaLanguage = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLanguage>();

        [XmlElement(ElementName = "searchCriteriaLanguage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
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
        protected bool SearchCriteriaLanguageSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName>();

        [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> SearchCriteriaDepartmentName
        {
            get => _searchCriteriaDepartmentName;
            set
            {
                SearchCriteriaDepartmentNameSpecified = true;
                _searchCriteriaDepartmentName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDepartmentNameSpecified { get; set; }

        protected bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1564")]
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
