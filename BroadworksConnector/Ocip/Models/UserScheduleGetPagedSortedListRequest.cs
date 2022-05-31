using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of schedules viewable by a User. The list can be filtered by schedule name,
    /// schedule type, and schedule level.
    /// The response is either a UserScheduleGetPagedSortedListResponse or an ErrorResponse.
    /// This command is authorized to user who is Executive-Assistant of the Executive.
    /// If no sortOrder is included, the response is sorted by Name ascending by default.
    /// If the responsePagingControl element is not provided, the paging startIndex will be
    /// set to 1 by default, and the responsePageSize will be set to the maximum
    /// responsePageSize by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option
    /// is included. Then the search criteria are logically ORed together.
    /// <see cref="UserScheduleGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3759""}]")]
    public class UserScheduleGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserScheduleGetPagedSortedListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3759")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3759")]
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

        protected BroadWorksConnector.Ocip.Models.SortByScheduleName _sortByScheduleName;

        [XmlElement(ElementName = "sortByScheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3759")]
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
        protected bool SortByScheduleNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaScheduleName> _searchCriteriaScheduleName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaScheduleName>();

        [XmlElement(ElementName = "searchCriteriaScheduleName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3759")]
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
        protected bool SearchCriteriaScheduleNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleType> _searchCriteriaExactScheduleType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleType>();

        [XmlElement(ElementName = "searchCriteriaExactScheduleType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3759")]
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
        protected bool SearchCriteriaExactScheduleTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel> _searchCriteriaExactScheduleLevel = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel>();

        [XmlElement(ElementName = "searchCriteriaExactScheduleLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3759")]
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
        protected bool SearchCriteriaExactScheduleLevelSpecified { get; set; }

        protected bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3759")]
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
