using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets a Custom Contact Directory in a group.
    /// The response is either UserGroupCustomContactDirectoryGetPagedSortedListResponse
    /// or ErrorResponse.
    /// The search can be done using multiple criterion.
    /// If the searchCriteriaModeOr is present, any result matching any one
    /// criteria is included in the results.
    /// Otherwise, only results matching all the search criterion are included in the
    /// results.
    /// If no search criteria is specified, all results are returned.
    /// Specifying searchCriteriaModeOr without any search criteria results
    /// in an ErrorResponse.
    /// The sort can be done on the user last name, first name, department, or
    /// contact notes.  The Receptionist Note column is only populated, if the
    /// user sending the request is a the owner of this Receptionist Note and a Note
    /// exists.
    /// <see cref="UserGroupCustomContactDirectoryGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2343"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2347""}]}]")]
    public class UserGroupCustomContactDirectoryGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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

        private BroadWorksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

        [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2347")]
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
        public bool SortByUserLastNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

        [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2347")]
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
        public bool SortByUserFirstNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByUserDepartment _sortByUserDepartment;

        [XmlElement(ElementName = "sortByUserDepartment", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2347")]
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
        public bool SortByUserDepartmentSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByReceptionistNote _sortByReceptionistNote;

        [XmlElement(ElementName = "sortByReceptionistNote", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2347")]
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
        public bool SortByReceptionistNoteSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaUserLastNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaUserFirstNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaDnSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaExtensionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> _searchCriteriaMobilePhoneNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber>();

        [XmlElement(ElementName = "searchCriteriaMobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaMobilePhoneNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaUserIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName>();

        [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaDepartmentNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> _searchCriteriaImpId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId>();

        [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaImpIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaTitle> _searchCriteriaTitle = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaTitle>();

        [XmlElement(ElementName = "searchCriteriaTitle", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaTitleSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote> _searchCriteriaReceptionistNote = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote>();

        [XmlElement(ElementName = "searchCriteriaReceptionistNote", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2343")]
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
        public bool SearchCriteriaReceptionistNoteSpecified { get; set; }

    }
}
