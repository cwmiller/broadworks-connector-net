using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a table containing the phone directory for a group.
    /// The directory includes all users in the group and all entries in the group common phone list.
    /// 
    /// If the specified group is part of an enterprise, the directory
    /// includes all users in the enterprise and all entries in the enterprise
    /// common phone list and the common phone list of the specified group.
    /// 
    /// If the specified group is part of a service provider, the directory
    /// includes all users in the group and all entries in the common phone
    /// list of the specified group.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// If no sortOrder is included the response is sorted by User Id ascending with a secondary
    /// sort by User Last Name ascending by default.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactUserDepartment have multiple entries and searchCriteriaModeOr is not included.
    /// 
    /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
    /// "sortByImpId"
    /// "searchCriteriaImpId"
    /// 
    /// The response is either GroupPhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupPhoneDirectoryGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5894""}]")]
    public class GroupPhoneDirectoryGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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

        private bool _isExtendedInfoRequested;

        [XmlElement(ElementName = "isExtendedInfoRequested", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
        public bool IsExtendedInfoRequested
        {
            get => _isExtendedInfoRequested;
            set
            {
                IsExtendedInfoRequestedSpecified = true;
                _isExtendedInfoRequested = value;
            }
        }

        [XmlIgnore]
        public bool IsExtendedInfoRequestedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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

        private List<BroadWorksConnector.Ocip.Models.SortOrderGroupPhoneDirectoryGetPagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderGroupPhoneDirectoryGetPagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderGroupPhoneDirectoryGetPagedSortedList> SortOrder
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> _searchCriteriaGroupLocationCode = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode>();

        [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode
        {
            get => _searchCriteriaGroupLocationCode;
            set
            {
                SearchCriteriaGroupLocationCodeSpecified = true;
                _searchCriteriaGroupLocationCode = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupLocationCodeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> _searchCriteriaMobilePhoneNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber>();

        [XmlElement(ElementName = "searchCriteriaMobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> SearchCriteriaMobilePhoneNumber
        {
            get => _searchCriteriaMobilePhoneNumber;
            set
            {
                SearchCriteriaMobilePhoneNumberSpecified = true;
                _searchCriteriaMobilePhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaMobilePhoneNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress>();

        [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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
        public bool SearchCriteriaEmailAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment> _searchCriteriaExactUserDepartment = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment>();

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName>();

        [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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
        public bool SearchCriteriaDepartmentNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup> _searchCriteriaExactUserGroup = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup>();

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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
        public bool SearchCriteriaExactUserGroupSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId> _searchCriteriaYahooId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId>();

        [XmlElement(ElementName = "searchCriteriaYahooId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId> SearchCriteriaYahooId
        {
            get => _searchCriteriaYahooId;
            set
            {
                SearchCriteriaYahooIdSpecified = true;
                _searchCriteriaYahooId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaYahooIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> _searchCriteriaImpId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId>();

        [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> SearchCriteriaImpId
        {
            get => _searchCriteriaImpId;
            set
            {
                SearchCriteriaImpIdSpecified = true;
                _searchCriteriaImpId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaImpIdSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5894")]
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
