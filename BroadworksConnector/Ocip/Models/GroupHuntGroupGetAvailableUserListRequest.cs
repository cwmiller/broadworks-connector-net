using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of users that can be assigned to a Hunt Group group.
    /// Searching for users by group only makes sense when the hunt group is part of an Enterprise.
    /// The response is either GroupHuntGroupGetAvailableUserListResponse or ErrorResponse.
    /// <see cref="GroupHuntGroupGetAvailableUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc829065f9d696d3ca7084121d57f8c0:245""}]")]
    public class GroupHuntGroupGetAvailableUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
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
        public bool GroupIdSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
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
        public bool SearchCriteriaUserLastNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
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
        public bool SearchCriteriaUserFirstNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment
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

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup _searchCriteriaExactUserGroup;

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup
        {
            get => _searchCriteriaExactUserGroup;
            set
            {
                SearchCriteriaExactUserGroupSpecified = true;
                _searchCriteriaExactUserGroup = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserGroupSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
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
        public bool SearchCriteriaUserIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
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
        public bool SearchCriteriaDnSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:245")]
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
        public bool SearchCriteriaExtensionSpecified { get; set; }

    }
}
