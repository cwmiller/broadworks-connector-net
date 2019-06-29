using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Agents in the Enterprise that can be assigned to a given Call Center Agent Threshold Profile in an Enterprise.
    /// An agent is available to be assigned to a given Agent Threshold Profile if it is a Call Center Standard or Call Center Premium agent
    /// and the agent is not yet assigned to the profile.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// The available agent list for a new Call Center Agent Threshold profile can be obtained by not setting the excludeAgentsAssignedToProfileName.
    /// When the excludeAgentsAssignedToProfileName is specified, all agents already assigned to the specified profile are not included in the response, even if the search
    /// criterion element searchCriteriaAgentThresholdProfile is specified using the same profile name.
    /// 
    /// If no sortOrder is included the response is sorted by User Id ascending by default.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// ErrorResponse is returned if searchCriteriaExactUserGroup has multiple entries and searchCriteriaModeOr is not included.
    /// 
    /// The response is either a EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse or an ErrorResponse.
    /// <see cref="ErrorResponse"/>
    /// <see cref="EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:494""}]")]
    public class EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
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

        private string _excludeAgentsAssignedToProfileName;

        [XmlElement(ElementName = "excludeAgentsAssignedToProfileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ExcludeAgentsAssignedToProfileName
        {
            get => _excludeAgentsAssignedToProfileName;
            set
            {
                ExcludeAgentsAssignedToProfileNameSpecified = true;
                _excludeAgentsAssignedToProfileName = value;
            }
        }

        [XmlIgnore]
        protected bool ExcludeAgentsAssignedToProfileNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
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

        private List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedList> SortOrder
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName
        {
            get => _searchCriteriaUserLastName;
            set
            {
                SearchCriteriaUserLastNameSpecified = true;
                _searchCriteriaUserLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserLastNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName
        {
            get => _searchCriteriaUserFirstName;
            set
            {
                SearchCriteriaUserFirstNameSpecified = true;
                _searchCriteriaUserFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserFirstNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress>();

        [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress
        {
            get => _searchCriteriaEmailAddress;
            set
            {
                SearchCriteriaEmailAddressSpecified = true;
                _searchCriteriaEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEmailAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAgentThresholdProfile> _searchCriteriaAgentThresholdProfile = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAgentThresholdProfile>();

        [XmlElement(ElementName = "searchCriteriaAgentThresholdProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAgentThresholdProfile> SearchCriteriaAgentThresholdProfile
        {
            get => _searchCriteriaAgentThresholdProfile;
            set
            {
                SearchCriteriaAgentThresholdProfileSpecified = true;
                _searchCriteriaAgentThresholdProfile = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaAgentThresholdProfileSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup> _searchCriteriaExactUserGroup = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup>();

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup> SearchCriteriaExactUserGroup
        {
            get => _searchCriteriaExactUserGroup;
            set
            {
                SearchCriteriaExactUserGroupSpecified = true;
                _searchCriteriaExactUserGroup = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactUserGroupSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:494")]
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
