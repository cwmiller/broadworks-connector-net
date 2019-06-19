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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1627"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1630""}]}]")]
    public class UserEnterpriseCommonPhoneListGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1627")]
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
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1627")]
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

        private BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber _sortByEnterpriseCommonPhoneListNumber;

        [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1630")]
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
        public bool SortByEnterpriseCommonPhoneListNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName _sortByEnterpriseCommonPhoneListName;

        [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1630")]
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
        public bool SortByEnterpriseCommonPhoneListNameSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1627")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> _searchCriteriaEnterpriseCommonPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1627")]
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
        public bool SearchCriteriaEnterpriseCommonPhoneListNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> _searchCriteriaEnterpriseCommonPhoneListNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1627")]
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
        public bool SearchCriteriaEnterpriseCommonPhoneListNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName> _searchCriteriaEnterpriseCommonMultiPartPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonMultiPartPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1627")]
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
        public bool SearchCriteriaEnterpriseCommonMultiPartPhoneListNameSpecified { get; set; }

    }
}
