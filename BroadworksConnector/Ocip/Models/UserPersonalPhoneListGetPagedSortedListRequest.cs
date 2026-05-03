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
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2970"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2973""}]}]")]
    public class UserPersonalPhoneListGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPersonalPhoneListGetPagedSortedListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2970")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2970")]
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

        protected BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber _sortByUserPersonalPhoneListNumber;

        [XmlElement(ElementName = "sortByUserPersonalPhoneListNumber", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2973")]
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

        protected BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListName _sortByUserPersonalPhoneListName;

        [XmlElement(ElementName = "sortByUserPersonalPhoneListName", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2973")]
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

        protected bool? _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2970")]
        public bool? SearchCriteriaModeOr
        {
            get => _searchCriteriaModeOr;
            set
            {
                SearchCriteriaModeOrSpecified = (value != null);
                _searchCriteriaModeOr = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaModeOrSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> _searchCriteriaUserPersonalPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2970")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> SearchCriteriaUserPersonalPhoneListName
        {
            get => _searchCriteriaUserPersonalPhoneListName;
            set
            {
                SearchCriteriaUserPersonalPhoneListNameSpecified = (value != null);
                _searchCriteriaUserPersonalPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserPersonalPhoneListNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> _searchCriteriaUserPersonalPhoneListNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber>();

        [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2970")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> SearchCriteriaUserPersonalPhoneListNumber
        {
            get => _searchCriteriaUserPersonalPhoneListNumber;
            set
            {
                SearchCriteriaUserPersonalPhoneListNumberSpecified = (value != null);
                _searchCriteriaUserPersonalPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserPersonalPhoneListNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName> _searchCriteriaUserPersonalMultiPartPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaUserPersonalMultiPartPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2970")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName> SearchCriteriaUserPersonalMultiPartPhoneListName
        {
            get => _searchCriteriaUserPersonalMultiPartPhoneListName;
            set
            {
                SearchCriteriaUserPersonalMultiPartPhoneListNameSpecified = (value != null);
                _searchCriteriaUserPersonalMultiPartPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserPersonalMultiPartPhoneListNameSpecified { get; set; }

    }
}
