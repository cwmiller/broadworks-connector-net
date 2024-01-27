using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a table containing the phone directory for a user.
    /// Setting isEnterpriseRequested to true will return enterprise directory
    /// members in the response if the user is in an enterprise.  Otherwise,
    /// just the group directory members for a user are returned in the
    /// response.
    /// The response is either UserPhoneDirectoryGetPagedSortedListResponse or ErrorResponse.
    /// The search can be done using multiple criteria.  If the searchCriteriaModeOr is present,
    /// any result matching any one criteria is included in the results. Otherwise, only results
    /// matching all the search criteria are included in the results.  If no search criteria is
    /// specified, all results are returned.  Specifying searchCriteriaModeOr
    /// without any search criteria results in an ErrorResponse.  The sort can be
    /// performed on user last name, first name, department, or receptionist note.
    /// The Receptionist Note column is only populated, if the user sending the request
    /// is the owner of the Receptionist Note and a Note exists.
    /// The following elements are only used in AS data mode and ignored in XS data
    /// mode:
    /// searchCriteriaMultiPartName
    /// <see cref="isEnterpriseRequest"/>
    /// <see cref="UserPhoneDirectoryGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3119"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3123""}]}]")]
    public class UserPhoneDirectoryGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPhoneDirectoryGetPagedSortedListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
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

        protected bool _isEnterpriseInfoRequested;

        [XmlElement(ElementName = "isEnterpriseInfoRequested", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public bool IsEnterpriseInfoRequested
        {
            get => _isEnterpriseInfoRequested;
            set
            {
                IsEnterpriseInfoRequestedSpecified = true;
                _isEnterpriseInfoRequested = value;
            }
        }

        [XmlIgnore]
        protected bool IsEnterpriseInfoRequestedSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
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

        protected BroadWorksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

        [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3123")]
        public BroadWorksConnector.Ocip.Models.SortByUserLastName SortByUserLastName
        {
            get => _sortByUserLastName;
            set
            {
                SortByUserLastNameSpecified = true;
                _sortByUserLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserLastNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

        [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3123")]
        public BroadWorksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName
        {
            get => _sortByUserFirstName;
            set
            {
                SortByUserFirstNameSpecified = true;
                _sortByUserFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserFirstNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByUserDepartment _sortByUserDepartment;

        [XmlElement(ElementName = "sortByUserDepartment", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3123")]
        public BroadWorksConnector.Ocip.Models.SortByUserDepartment SortByUserDepartment
        {
            get => _sortByUserDepartment;
            set
            {
                SortByUserDepartmentSpecified = true;
                _sortByUserDepartment = value;
            }
        }

        [XmlIgnore]
        protected bool SortByUserDepartmentSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByReceptionistNote _sortByReceptionistNote;

        [XmlElement(ElementName = "sortByReceptionistNote", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3123")]
        public BroadWorksConnector.Ocip.Models.SortByReceptionistNote SortByReceptionistNote
        {
            get => _sortByReceptionistNote;
            set
            {
                SortByReceptionistNoteSpecified = true;
                _sortByReceptionistNote = value;
            }
        }

        [XmlIgnore]
        protected bool SortByReceptionistNoteSpecified { get; set; }

        protected bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName
        {
            get => _searchCriteriaUserLastName;
            set
            {
                SearchCriteriaUserLastNameSpecified = true;
                _searchCriteriaUserLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserLastNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName
        {
            get => _searchCriteriaUserFirstName;
            set
            {
                SearchCriteriaUserFirstNameSpecified = true;
                _searchCriteriaUserFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserFirstNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserName> _searchCriteriaUserName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserName>();

        [XmlElement(ElementName = "searchCriteriaUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserName> SearchCriteriaUserName
        {
            get => _searchCriteriaUserName;
            set
            {
                SearchCriteriaUserNameSpecified = true;
                _searchCriteriaUserName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn
        {
            get => _searchCriteriaDn;
            set
            {
                SearchCriteriaDnSpecified = true;
                _searchCriteriaDn = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDnSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> _searchCriteriaGroupLocationCode = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode>();

        [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode
        {
            get => _searchCriteriaGroupLocationCode;
            set
            {
                SearchCriteriaGroupLocationCodeSpecified = true;
                _searchCriteriaGroupLocationCode = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaGroupLocationCodeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension
        {
            get => _searchCriteriaExtension;
            set
            {
                SearchCriteriaExtensionSpecified = true;
                _searchCriteriaExtension = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExtensionSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> _searchCriteriaMobilePhoneNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber>();

        [XmlElement(ElementName = "searchCriteriaMobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> SearchCriteriaMobilePhoneNumber
        {
            get => _searchCriteriaMobilePhoneNumber;
            set
            {
                SearchCriteriaMobilePhoneNumberSpecified = true;
                _searchCriteriaMobilePhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaMobilePhoneNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress>();

        [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress
        {
            get => _searchCriteriaEmailAddress;
            set
            {
                SearchCriteriaEmailAddressSpecified = true;
                _searchCriteriaEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEmailAddressSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId> _searchCriteriaYahooId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId>();

        [XmlElement(ElementName = "searchCriteriaYahooId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId> SearchCriteriaYahooId
        {
            get => _searchCriteriaYahooId;
            set
            {
                SearchCriteriaYahooIdSpecified = true;
                _searchCriteriaYahooId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaYahooIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup _searchCriteriaExactUserGroup;

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup
        {
            get => _searchCriteriaExactUserGroup;
            set
            {
                SearchCriteriaExactUserGroupSpecified = true;
                _searchCriteriaExactUserGroup = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactUserGroupSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName>();

        [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> SearchCriteriaDepartmentName
        {
            get => _searchCriteriaDepartmentName;
            set
            {
                SearchCriteriaDepartmentNameSpecified = true;
                _searchCriteriaDepartmentName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDepartmentNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId
        {
            get => _searchCriteriaUserId;
            set
            {
                SearchCriteriaUserIdSpecified = true;
                _searchCriteriaUserId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> _searchCriteriaImpId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId>();

        [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> SearchCriteriaImpId
        {
            get => _searchCriteriaImpId;
            set
            {
                SearchCriteriaImpIdSpecified = true;
                _searchCriteriaImpId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaImpIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaTitle> _searchCriteriaTitle = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaTitle>();

        [XmlElement(ElementName = "searchCriteriaTitle", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaTitle> SearchCriteriaTitle
        {
            get => _searchCriteriaTitle;
            set
            {
                SearchCriteriaTitleSpecified = true;
                _searchCriteriaTitle = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaTitleSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote> _searchCriteriaReceptionistNote = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote>();

        [XmlElement(ElementName = "searchCriteriaReceptionistNote", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote> SearchCriteriaReceptionistNote
        {
            get => _searchCriteriaReceptionistNote;
            set
            {
                SearchCriteriaReceptionistNoteSpecified = true;
                _searchCriteriaReceptionistNote = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaReceptionistNoteSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaMultiPartUserName> _searchCriteriaMultiPartName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaMultiPartUserName>();

        [XmlElement(ElementName = "searchCriteriaMultiPartName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3119")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaMultiPartUserName> SearchCriteriaMultiPartName
        {
            get => _searchCriteriaMultiPartName;
            set
            {
                SearchCriteriaMultiPartNameSpecified = true;
                _searchCriteriaMultiPartName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaMultiPartNameSpecified { get; set; }

    }
}
