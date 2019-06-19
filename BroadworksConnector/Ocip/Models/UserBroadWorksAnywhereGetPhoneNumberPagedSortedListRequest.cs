using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
    /// If no sortOrder is included the response is sorted by Phone Number ascending by default.
    /// The response is either a UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse or an ErrorResponse.
    /// <see cref="UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:381"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:384"",""optional"":true}]}]")]
    public class UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:381")]
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
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:381")]
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

        private BroadWorksConnector.Ocip.Models.SortByLocation _sortByLocation;

        [XmlElement(ElementName = "sortByLocation", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:384")]
        public BroadWorksConnector.Ocip.Models.SortByLocation SortByLocation
        {
            get => _sortByLocation;
            set
            {
                SortByLocationSpecified = true;
                _sortByLocation = value;
            }
        }

        [XmlIgnore]
        public bool SortByLocationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByEnabled _sortByEnabled;

        [XmlElement(ElementName = "sortByEnabled", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:384")]
        public BroadWorksConnector.Ocip.Models.SortByEnabled SortByEnabled
        {
            get => _sortByEnabled;
            set
            {
                SortByEnabledSpecified = true;
                _sortByEnabled = value;
            }
        }

        [XmlIgnore]
        public bool SortByEnabledSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaLocation> _searchCriteriaLocation = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLocation>();

        [XmlElement(ElementName = "searchCriteriaLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:381")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaLocation> SearchCriteriaLocation
        {
            get => _searchCriteriaLocation;
            set
            {
                SearchCriteriaLocationSpecified = true;
                _searchCriteriaLocation = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaLocationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactLocationEnabled _searchCriteriaExactLocationEnabled;

        [XmlElement(ElementName = "searchCriteriaExactLocationEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:381")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactLocationEnabled SearchCriteriaExactLocationEnabled
        {
            get => _searchCriteriaExactLocationEnabled;
            set
            {
                SearchCriteriaExactLocationEnabledSpecified = true;
                _searchCriteriaExactLocationEnabled = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactLocationEnabledSpecified { get; set; }

    }
}
