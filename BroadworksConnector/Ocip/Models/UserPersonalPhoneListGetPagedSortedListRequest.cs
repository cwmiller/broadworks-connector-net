using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a user's personal phone list.
    /// The response is either a UserPersonalPhoneListGetPagedSortedListResponse or an
    /// ErrorResponse.
    /// The search can be done using multiple criterion.
    /// If the searchCriteriaModeOr is present, any result matching any one
    /// criteria is included in the results.
    /// Otherwise, only results matching all the search criterion are included in the
    /// results.
    /// If no search criteria is specified, all results are returned.
    /// Specifying searchCriteriaModeOr without any search criteria results
    /// in an ErrorResponse.
    /// The sort can done by the personal phone list number or name.
    /// The following elements are only used in AS data mode and ignored in XS data
    /// mode:
    /// searchCriteriaUserPersonalMultiPartPhoneListName
    /// <see cref="UserPersonalPhoneListGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2842"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2845""}]}]")]
    public class UserPersonalPhoneListGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2842")]
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

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2842")]
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

        private BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber _sortByUserPersonalPhoneListNumber;

        [XmlElement(ElementName = "sortByUserPersonalPhoneListNumber", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2845")]
        public BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber SortByUserPersonalPhoneListNumber
        {
            get => _sortByUserPersonalPhoneListNumber;
            set
            {
                SortByUserPersonalPhoneListNumberSpecified = true;
                _sortByUserPersonalPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserPersonalPhoneListNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListName _sortByUserPersonalPhoneListName;

        [XmlElement(ElementName = "sortByUserPersonalPhoneListName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2845")]
        public BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListName SortByUserPersonalPhoneListName
        {
            get => _sortByUserPersonalPhoneListName;
            set
            {
                SortByUserPersonalPhoneListNameSpecified = true;
                _sortByUserPersonalPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserPersonalPhoneListNameSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2842")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> _searchCriteriaUserPersonalPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2842")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> SearchCriteriaUserPersonalPhoneListName
        {
            get => _searchCriteriaUserPersonalPhoneListName;
            set
            {
                SearchCriteriaUserPersonalPhoneListNameSpecified = true;
                _searchCriteriaUserPersonalPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserPersonalPhoneListNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> _searchCriteriaUserPersonalPhoneListNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber>();

        [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2842")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> SearchCriteriaUserPersonalPhoneListNumber
        {
            get => _searchCriteriaUserPersonalPhoneListNumber;
            set
            {
                SearchCriteriaUserPersonalPhoneListNumberSpecified = true;
                _searchCriteriaUserPersonalPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserPersonalPhoneListNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName> _searchCriteriaUserPersonalMultiPartPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaUserPersonalMultiPartPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2842")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName> SearchCriteriaUserPersonalMultiPartPhoneListName
        {
            get => _searchCriteriaUserPersonalMultiPartPhoneListName;
            set
            {
                SearchCriteriaUserPersonalMultiPartPhoneListNameSpecified = true;
                _searchCriteriaUserPersonalMultiPartPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserPersonalMultiPartPhoneListNameSpecified { get; set; }

    }
}
