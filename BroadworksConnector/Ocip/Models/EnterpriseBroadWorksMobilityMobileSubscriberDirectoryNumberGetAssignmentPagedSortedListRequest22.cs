using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a summary table of all Mobile Subscriber Directory Numbers in an enterprise.
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the  responsePageSize will be set to  the maximum ResponsePageSize by default.
    /// If no sortOrder is included the response is sorted by Mobile Number ascending by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// The department in both the search criteria and sort by fields refer to the department of the user.
    /// The response is either EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse22 or ErrorResponse.
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:156""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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

        private bool _includeTotalNumberOfRows;

        [XmlElement(ElementName = "includeTotalNumberOfRows", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
        public bool IncludeTotalNumberOfRows
        {
            get => _includeTotalNumberOfRows;
            set
            {
                IncludeTotalNumberOfRowsSpecified = true;
                _includeTotalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeTotalNumberOfRowsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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

        private List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedList> SortOrder
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> _searchCriteriaMobileSubscriberDirectoryNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber>();

        [XmlElement(ElementName = "searchCriteriaMobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> SearchCriteriaMobileSubscriberDirectoryNumber
        {
            get => _searchCriteriaMobileSubscriberDirectoryNumber;
            set
            {
                SearchCriteriaMobileSubscriberDirectoryNumberSpecified = true;
                _searchCriteriaMobileSubscriberDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaMobileSubscriberDirectoryNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId>();

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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
        protected bool SearchCriteriaGroupIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork> _searchCriteriaExactMobileNetwork = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork>();

        [XmlElement(ElementName = "searchCriteriaExactMobileNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork> SearchCriteriaExactMobileNetwork
        {
            get => _searchCriteriaExactMobileNetwork;
            set
            {
                SearchCriteriaExactMobileNetworkSpecified = true;
                _searchCriteriaExactMobileNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactMobileNetworkSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactMobileDnAvailability _searchCriteriaExactMobileDnAvailability;

        [XmlElement(ElementName = "searchCriteriaExactMobileDnAvailability", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactMobileDnAvailability SearchCriteriaExactMobileDnAvailability
        {
            get => _searchCriteriaExactMobileDnAvailability;
            set
            {
                SearchCriteriaExactMobileDnAvailabilitySpecified = true;
                _searchCriteriaExactMobileDnAvailability = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactMobileDnAvailabilitySpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:156")]
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
