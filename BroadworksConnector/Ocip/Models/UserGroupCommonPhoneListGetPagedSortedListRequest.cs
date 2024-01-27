using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a user's group's common phone list.
    /// The response is either a UserGroupCommonPhoneListGetPagedSortedListResponse or an
    /// ErrorResponse.
    /// The search can be done using multiple criterion.
    /// If the searchCriteriaModeOr is present, any result matching any one
    /// criteria is included in the results.
    /// Otherwise, only results matching all the search criterion are included in the
    /// results.
    /// If no search criteria is specified, all results are returned.
    /// Specifying searchCriteriaModeOr without any search criteria results
    /// in an ErrorResponse.
    /// The sort can be done on the name or the number in the common phone list.
    /// The following elements are only used in AS data mode and ignored in XS data
    /// mode:
    /// searchCriteriaGroupCommonMultiPartPhoneListName
    /// <see cref="UserGroupCommonPhoneListGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2335"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2338""}]}]")]
    public class UserGroupCommonPhoneListGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserGroupCommonPhoneListGetPagedSortedListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2335")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2335")]
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

        protected BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListNumber _sortByGroupCommonPhoneListNumber;

        [XmlElement(ElementName = "sortByGroupCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2338")]
        public BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListNumber SortByGroupCommonPhoneListNumber
        {
            get => _sortByGroupCommonPhoneListNumber;
            set
            {
                SortByGroupCommonPhoneListNumberSpecified = true;
                _sortByGroupCommonPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SortByGroupCommonPhoneListNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListName _sortByGroupCommonPhoneListName;

        [XmlElement(ElementName = "sortByGroupCommonPhoneListName", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2338")]
        public BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListName SortByGroupCommonPhoneListName
        {
            get => _sortByGroupCommonPhoneListName;
            set
            {
                SortByGroupCommonPhoneListNameSpecified = true;
                _sortByGroupCommonPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByGroupCommonPhoneListNameSpecified { get; set; }

        protected bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2335")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> _searchCriteriaGroupCommonPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2335")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> SearchCriteriaGroupCommonPhoneListName
        {
            get => _searchCriteriaGroupCommonPhoneListName;
            set
            {
                SearchCriteriaGroupCommonPhoneListNameSpecified = true;
                _searchCriteriaGroupCommonPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaGroupCommonPhoneListNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> _searchCriteriaGroupCommonPhoneListNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber>();

        [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2335")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> SearchCriteriaGroupCommonPhoneListNumber
        {
            get => _searchCriteriaGroupCommonPhoneListNumber;
            set
            {
                SearchCriteriaGroupCommonPhoneListNumberSpecified = true;
                _searchCriteriaGroupCommonPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaGroupCommonPhoneListNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonMultiPartPhoneListName> _searchCriteriaGroupCommonMultiPartPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonMultiPartPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaGroupCommonMultiPartPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2335")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonMultiPartPhoneListName> SearchCriteriaGroupCommonMultiPartPhoneListName
        {
            get => _searchCriteriaGroupCommonMultiPartPhoneListName;
            set
            {
                SearchCriteriaGroupCommonMultiPartPhoneListNameSpecified = true;
                _searchCriteriaGroupCommonMultiPartPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaGroupCommonMultiPartPhoneListNameSpecified { get; set; }

    }
}
