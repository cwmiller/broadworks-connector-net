using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of schedules viewable by a group.
    /// The response is either a GroupScheduleGetPagedSortedListResponse or an ErrorResponse.
    /// If no sortOrder is included, the response is sorted by Name ascending by default.
    /// If the responsePagingControl element is not provided, the paging startIndex will be
    /// set to 1 by default, and the responsePageSize will be set to the maximum
    /// responsePageSize by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option
    /// is included. Then the search criteria are logically ORed together.
    /// <see cref="GroupScheduleGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6542""}]")]
    public class GroupScheduleGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
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

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
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

        private BroadWorksConnector.Ocip.Models.SortByScheduleName _sortByScheduleName;

        [XmlElement(ElementName = "sortByScheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
        public BroadWorksConnector.Ocip.Models.SortByScheduleName SortByScheduleName
        {
            get => _sortByScheduleName;
            set
            {
                SortByScheduleNameSpecified = true;
                _sortByScheduleName = value;
            }
        }

        [XmlIgnore]
        public bool SortByScheduleNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaScheduleName> _searchCriteriaScheduleName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaScheduleName>();

        [XmlElement(ElementName = "searchCriteriaScheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaScheduleName> SearchCriteriaScheduleName
        {
            get => _searchCriteriaScheduleName;
            set
            {
                SearchCriteriaScheduleNameSpecified = true;
                _searchCriteriaScheduleName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaScheduleNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleType> _searchCriteriaExactScheduleType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleType>();

        [XmlElement(ElementName = "searchCriteriaExactScheduleType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleType> SearchCriteriaExactScheduleType
        {
            get => _searchCriteriaExactScheduleType;
            set
            {
                SearchCriteriaExactScheduleTypeSpecified = true;
                _searchCriteriaExactScheduleType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactScheduleTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel> _searchCriteriaExactScheduleLevel = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel>();

        [XmlElement(ElementName = "searchCriteriaExactScheduleLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel> SearchCriteriaExactScheduleLevel
        {
            get => _searchCriteriaExactScheduleLevel;
            set
            {
                SearchCriteriaExactScheduleLevelSpecified = true;
                _searchCriteriaExactScheduleLevel = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactScheduleLevelSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6542")]
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
