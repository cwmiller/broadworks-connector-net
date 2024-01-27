using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Auto Attendant instances within a group.
    /// The response is either GroupAutoAttendantGetInstancePagedSortedListResponse or ErrorResponse.
    /// If no sortOrder is included the response is sorted by Name ascending by default.
    /// 
    /// A limitation to the search by DN activation exists when the Number Activation mode is set to
    /// Off. In this case DNs not assigned to users are never returned by queries with the
    /// "dnActivationSearchCriteria" included.
    /// 
    /// If the responsePagingControl element is not provided,
    /// the paging startIndex will be set to 1 by default,
    /// and the responsePageSize will be set to the maximum responsePageSize by
    /// default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// <see cref="GroupAutoAttendantGetInstancePagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:288""}]")]
    public class GroupAutoAttendantGetInstancePagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupAutoAttendantGetInstancePagedSortedListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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

        protected List<BroadWorksConnector.Ocip.Models.SortOrderGroupAutoAttendantGetInstancePagedSortedList> _sortOrder = new List<BroadWorksConnector.Ocip.Models.SortOrderGroupAutoAttendantGetInstancePagedSortedList>();

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
        public List<BroadWorksConnector.Ocip.Models.SortOrderGroupAutoAttendantGetInstancePagedSortedList> SortOrder
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactDnActivation _searchCriteriaExactDnActivation;

        [XmlElement(ElementName = "searchCriteriaExactDnActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDnActivation SearchCriteriaExactDnActivation
        {
            get => _searchCriteriaExactDnActivation;
            set
            {
                SearchCriteriaExactDnActivationSpecified = true;
                _searchCriteriaExactDnActivation = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactDnActivationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaServiceStatus _searchCriteriaServiceStatus;

        [XmlElement(ElementName = "searchCriteriaServiceStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactAutoAttendantType _searchCriteriaExactAutoAttendantType;

        [XmlElement(ElementName = "searchCriteriaExactAutoAttendantType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactAutoAttendantType SearchCriteriaExactAutoAttendantType
        {
            get => _searchCriteriaExactAutoAttendantType;
            set
            {
                SearchCriteriaExactAutoAttendantTypeSpecified = true;
                _searchCriteriaExactAutoAttendantType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactAutoAttendantTypeSpecified { get; set; }

        protected bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:288")]
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
