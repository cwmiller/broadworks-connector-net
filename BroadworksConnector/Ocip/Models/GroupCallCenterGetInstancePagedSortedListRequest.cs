using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Call Center instances within a group.
    /// The response is either GroupCallCenterGetInstancePagedSortedListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// If no sortOrder is included the response is sorted by User Id ascending by default.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// ErrorResponse is returned if searchCriteriaExactHuntPolicy or searchCriteriaExactCallCenterType have multiple entries and searchCriteriaModeOr is not include.
    /// <see cref="GroupCallCenterGetInstancePagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4531""}]")]
    public class GroupCallCenterGetInstancePagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetInstancePagedSortedListResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
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

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
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

        private List<BroadWorksConnector.Ocip.Models.SortOrderGroupCallCenterGetInstancePagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderGroupCallCenterGetInstancePagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderGroupCallCenterGetInstancePagedSortedList> SortOrder
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId
        {
            get => _searchCriteriaUserId;
            set
            {
                SearchCriteriaUserIdSpecified = true;
                _searchCriteriaUserId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName> _searchCriteriaCallCenterName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName>();

        [XmlElement(ElementName = "searchCriteriaCallCenterName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName> SearchCriteriaCallCenterName
        {
            get => _searchCriteriaCallCenterName;
            set
            {
                SearchCriteriaCallCenterNameSpecified = true;
                _searchCriteriaCallCenterName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaCallCenterNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn
        {
            get => _searchCriteriaDn;
            set
            {
                SearchCriteriaDnSpecified = true;
                _searchCriteriaDn = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDnSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension
        {
            get => _searchCriteriaExtension;
            set
            {
                SearchCriteriaExtensionSpecified = true;
                _searchCriteriaExtension = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExtensionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName>();

        [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
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

        private BroadWorksConnector.Ocip.Models.SearchCriteriaServiceStatus _searchCriteriaServiceStatus;

        [XmlElement(ElementName = "searchCriteriaServiceStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaServiceStatus SearchCriteriaServiceStatus
        {
            get => _searchCriteriaServiceStatus;
            set
            {
                SearchCriteriaServiceStatusSpecified = true;
                _searchCriteriaServiceStatus = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceStatusSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactHuntPolicy> _searchCriteriaExactHuntPolicy = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactHuntPolicy>();

        [XmlElement(ElementName = "searchCriteriaExactHuntPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactHuntPolicy> SearchCriteriaExactHuntPolicy
        {
            get => _searchCriteriaExactHuntPolicy;
            set
            {
                SearchCriteriaExactHuntPolicySpecified = true;
                _searchCriteriaExactHuntPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactHuntPolicySpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterType> _searchCriteriaExactCallCenterType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterType>();

        [XmlElement(ElementName = "searchCriteriaExactCallCenterType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterType> SearchCriteriaExactCallCenterType
        {
            get => _searchCriteriaExactCallCenterType;
            set
            {
                SearchCriteriaExactCallCenterTypeSpecified = true;
                _searchCriteriaExactCallCenterType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactCallCenterTypeSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4531")]
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
