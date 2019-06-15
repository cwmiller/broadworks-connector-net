using System;
using System.Xml.Serialization;
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
     
    public class UserPersonalPhoneListGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl {
            get => _responsePagingControl;
            set {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        public bool ResponsePagingControlSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber _sortByUserPersonalPhoneListNumber;

        [XmlElement(ElementName = "sortByUserPersonalPhoneListNumber", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber SortByUserPersonalPhoneListNumber {
            get => _sortByUserPersonalPhoneListNumber;
            set {
                SortByUserPersonalPhoneListNumberSpecified = true;
                _sortByUserPersonalPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserPersonalPhoneListNumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListName _sortByUserPersonalPhoneListName;

        [XmlElement(ElementName = "sortByUserPersonalPhoneListName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SortByUserPersonalPhoneListName SortByUserPersonalPhoneListName {
            get => _sortByUserPersonalPhoneListName;
            set {
                SortByUserPersonalPhoneListNameSpecified = true;
                _sortByUserPersonalPhoneListName = value;
            }
        }

        [XmlIgnore]
        public bool SortByUserPersonalPhoneListNameSpecified { get; set; }
        
        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        public bool SearchCriteriaModeOr {
            get => _searchCriteriaModeOr;
            set {
                SearchCriteriaModeOrSpecified = true;
                _searchCriteriaModeOr = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaModeOrSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> _searchCriteriaUserPersonalPhoneListName;

        [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> SearchCriteriaUserPersonalPhoneListName {
            get => _searchCriteriaUserPersonalPhoneListName;
            set {
                SearchCriteriaUserPersonalPhoneListNameSpecified = true;
                _searchCriteriaUserPersonalPhoneListName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserPersonalPhoneListNameSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> _searchCriteriaUserPersonalPhoneListNumber;

        [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> SearchCriteriaUserPersonalPhoneListNumber {
            get => _searchCriteriaUserPersonalPhoneListNumber;
            set {
                SearchCriteriaUserPersonalPhoneListNumberSpecified = true;
                _searchCriteriaUserPersonalPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserPersonalPhoneListNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName> _searchCriteriaUserPersonalMultiPartPhoneListName;

        [XmlElement(ElementName = "searchCriteriaUserPersonalMultiPartPhoneListName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName> SearchCriteriaUserPersonalMultiPartPhoneListName {
            get => _searchCriteriaUserPersonalMultiPartPhoneListName;
            set {
                SearchCriteriaUserPersonalMultiPartPhoneListNameSpecified = true;
                _searchCriteriaUserPersonalMultiPartPhoneListName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserPersonalMultiPartPhoneListNameSpecified { get; set; }
        
    }
}
