using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an enterprise's common phone list for a user.
    /// The response is either a UserEnterpriseCommonPhoneListGetPagedSortedListResponse
    /// or an ErrorResponse.
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
    /// searchCriteriaEnterpriseCommonMultiPartPhoneListName
    /// <see cref="UserEnterpriseCommonPhoneListGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:1733"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:1736""}]}]")]
    public class UserEnterpriseCommonPhoneListGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserEnterpriseCommonPhoneListGetPagedSortedListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1733")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1733")]
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

        protected BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber _sortByEnterpriseCommonPhoneListNumber;

        [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1736")]
        public BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber SortByEnterpriseCommonPhoneListNumber
        {
            get => _sortByEnterpriseCommonPhoneListNumber;
            set
            {
                SortByEnterpriseCommonPhoneListNumberSpecified = true;
                _sortByEnterpriseCommonPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SortByEnterpriseCommonPhoneListNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName _sortByEnterpriseCommonPhoneListName;

        [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1736")]
        public BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName SortByEnterpriseCommonPhoneListName
        {
            get => _sortByEnterpriseCommonPhoneListName;
            set
            {
                SortByEnterpriseCommonPhoneListNameSpecified = true;
                _sortByEnterpriseCommonPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByEnterpriseCommonPhoneListNameSpecified { get; set; }

        protected bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1733")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> _searchCriteriaEnterpriseCommonPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1733")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> SearchCriteriaEnterpriseCommonPhoneListName
        {
            get => _searchCriteriaEnterpriseCommonPhoneListName;
            set
            {
                SearchCriteriaEnterpriseCommonPhoneListNameSpecified = true;
                _searchCriteriaEnterpriseCommonPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEnterpriseCommonPhoneListNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> _searchCriteriaEnterpriseCommonPhoneListNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1733")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> SearchCriteriaEnterpriseCommonPhoneListNumber
        {
            get => _searchCriteriaEnterpriseCommonPhoneListNumber;
            set
            {
                SearchCriteriaEnterpriseCommonPhoneListNumberSpecified = true;
                _searchCriteriaEnterpriseCommonPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEnterpriseCommonPhoneListNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName> _searchCriteriaEnterpriseCommonMultiPartPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonMultiPartPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1733")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName> SearchCriteriaEnterpriseCommonMultiPartPhoneListName
        {
            get => _searchCriteriaEnterpriseCommonMultiPartPhoneListName;
            set
            {
                SearchCriteriaEnterpriseCommonMultiPartPhoneListNameSpecified = true;
                _searchCriteriaEnterpriseCommonMultiPartPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEnterpriseCommonMultiPartPhoneListNameSpecified { get; set; }

    }
}
