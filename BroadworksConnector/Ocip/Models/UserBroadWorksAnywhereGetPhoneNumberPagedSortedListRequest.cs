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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:382"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:385"",""optional"":true}]}]")]
    public class UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:382")]
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
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:382")]
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

        protected BroadWorksConnector.Ocip.Models.SortByLocation _sortByLocation;

        [XmlElement(ElementName = "sortByLocation", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:385")]
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
        protected bool SortByLocationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByEnabled _sortByEnabled;

        [XmlElement(ElementName = "sortByEnabled", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:385")]
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
        protected bool SortByEnabledSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaLocation> _searchCriteriaLocation = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLocation>();

        [XmlElement(ElementName = "searchCriteriaLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:382")]
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
        protected bool SearchCriteriaLocationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactLocationEnabled _searchCriteriaExactLocationEnabled;

        [XmlElement(ElementName = "searchCriteriaExactLocationEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:382")]
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
        protected bool SearchCriteriaExactLocationEnabledSpecified { get; set; }

    }
}
