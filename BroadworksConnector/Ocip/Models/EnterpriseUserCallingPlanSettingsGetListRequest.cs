using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseUserCallingPlanSettingsGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
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
        private BroadworksConnector.Ocip.Models.CallingPlanService _callingPlanService;

        [XmlElement(ElementName = "callingPlanService", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallingPlanService CallingPlanService
        {
            get => _callingPlanService;
            set
            {
                CallingPlanServiceSpecified = true;
                _callingPlanService = value;
            }
        }

        [XmlIgnore]
        public bool CallingPlanServiceSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl
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
        private BroadworksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

        [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName
        {
            get => _sortByUserLastName;
            set
            {
                SortByUserLastNameSpecified = true;
                _sortByUserLastName = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserLastNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

        [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName
        {
            get => _sortByUserFirstName;
            set
            {
                SortByUserFirstNameSpecified = true;
                _sortByUserFirstName = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserFirstNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SortByUserDepartment _sortByUserDepartment;

        [XmlElement(ElementName = "sortByUserDepartment", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SortByUserDepartment SortByUserDepartment
        {
            get => _sortByUserDepartment;
            set
            {
                SortByUserDepartmentSpecified = true;
                _sortByUserDepartment = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserDepartmentSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SortByDn _sortByDn;

        [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SortByDn SortByDn
        {
            get => _sortByDn;
            set
            {
                SortByDnSpecified = true;
                _sortByDn = value;
            }
        }

        [XmlIgnore]
        public bool SortByDnSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SortByExtension _sortByExtension;

        [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SortByExtension SortByExtension
        {
            get => _sortByExtension;
            set
            {
                SortByExtensionSpecified = true;
                _sortByExtension = value;
            }
        }

        [XmlIgnore]
        public bool SortByExtensionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SortByGroupId _sortByGroupId;

        [XmlElement(ElementName = "sortByGroupId", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SortByGroupId SortByGroupId
        {
            get => _sortByGroupId;
            set
            {
                SortByGroupIdSpecified = true;
                _sortByGroupId = value;
            }
        }

        [XmlIgnore]
        public bool SortByGroupIdSpecified { get; set; }
        private bool _includeVirtualUsers;

        [XmlElement(ElementName = "includeVirtualUsers", IsNullable = false, Namespace = "")]
        public bool IncludeVirtualUsers
        {
            get => _includeVirtualUsers;
            set
            {
                IncludeVirtualUsersSpecified = true;
                _includeVirtualUsers = value;
            }
        }

        [XmlIgnore]
        public bool IncludeVirtualUsersSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName;

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName
        {
            get => _searchCriteriaUserLastName;
            set
            {
                SearchCriteriaUserLastNameSpecified = true;
                _searchCriteriaUserLastName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserLastNameSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName;

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName
        {
            get => _searchCriteriaUserFirstName;
            set
            {
                SearchCriteriaUserFirstNameSpecified = true;
                _searchCriteriaUserFirstName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserFirstNameSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId;

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId
        {
            get => _searchCriteriaUserId;
            set
            {
                SearchCriteriaUserIdSpecified = true;
                _searchCriteriaUserId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserIdSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn;

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn
        {
            get => _searchCriteriaDn;
            set
            {
                SearchCriteriaDnSpecified = true;
                _searchCriteriaDn = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDnSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension;

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension
        {
            get => _searchCriteriaExtension;
            set
            {
                SearchCriteriaExtensionSpecified = true;
                _searchCriteriaExtension = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExtensionSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress;

        [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress
        {
            get => _searchCriteriaEmailAddress;
            set
            {
                SearchCriteriaEmailAddressSpecified = true;
                _searchCriteriaEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaEmailAddressSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment
        {
            get => _searchCriteriaExactUserDepartment;
            set
            {
                SearchCriteriaExactUserDepartmentSpecified = true;
                _searchCriteriaExactUserDepartment = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserDepartmentSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup _searchCriteriaExactUserInTrunkGroup;

        [XmlElement(ElementName = "searchCriteriaExactUserInTrunkGroup", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup SearchCriteriaExactUserInTrunkGroup
        {
            get => _searchCriteriaExactUserInTrunkGroup;
            set
            {
                SearchCriteriaExactUserInTrunkGroupSpecified = true;
                _searchCriteriaExactUserInTrunkGroup = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserInTrunkGroupSpecified { get; set; }
    }
}
