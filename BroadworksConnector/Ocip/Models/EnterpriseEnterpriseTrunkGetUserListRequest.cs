using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of users in an enterprise trunk.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// Multiple search criteria are logically ANDed together.
    /// The response is either a EnterpriseEnterpriseTrunkGetUserListResponse or an ErrorResponse.
    /// <see cref="EnterpriseEnterpriseTrunkGetUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:373""}]")]
    public class EnterpriseEnterpriseTrunkGetUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
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

        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
        [MinLength(1)]
        [MaxLength(30)]
        public string EnterpriseTrunkName
        {
            get => _enterpriseTrunkName;
            set
            {
                EnterpriseTrunkNameSpecified = true;
                _enterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkNameSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
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
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
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
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId>();

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId
        {
            get => _searchCriteriaGroupId;
            set
            {
                SearchCriteriaGroupIdSpecified = true;
                _searchCriteriaGroupId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentity> _searchCriteriaAlternateTrunkIdentity = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentity>();

        [XmlElement(ElementName = "searchCriteriaAlternateTrunkIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentity> SearchCriteriaAlternateTrunkIdentity
        {
            get => _searchCriteriaAlternateTrunkIdentity;
            set
            {
                SearchCriteriaAlternateTrunkIdentitySpecified = true;
                _searchCriteriaAlternateTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAlternateTrunkIdentitySpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentityDomain> _searchCriteriaAlternateTrunkIdentityDomain = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentityDomain>();

        [XmlElement(ElementName = "searchCriteriaAlternateTrunkIdentityDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAlternateTrunkIdentityDomain> SearchCriteriaAlternateTrunkIdentityDomain
        {
            get => _searchCriteriaAlternateTrunkIdentityDomain;
            set
            {
                SearchCriteriaAlternateTrunkIdentityDomainSpecified = true;
                _searchCriteriaAlternateTrunkIdentityDomain = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAlternateTrunkIdentityDomainSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment> _searchCriteriaExactUserDepartment = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment>();

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment> SearchCriteriaExactUserDepartment
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserRouteListAssigned> _searchCriteriaExactUserRouteListAssigned = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserRouteListAssigned>();

        [XmlElement(ElementName = "searchCriteriaExactUserRouteListAssigned", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:373")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserRouteListAssigned> SearchCriteriaExactUserRouteListAssigned
        {
            get => _searchCriteriaExactUserRouteListAssigned;
            set
            {
                SearchCriteriaExactUserRouteListAssignedSpecified = true;
                _searchCriteriaExactUserRouteListAssigned = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserRouteListAssignedSpecified { get; set; }

    }
}
