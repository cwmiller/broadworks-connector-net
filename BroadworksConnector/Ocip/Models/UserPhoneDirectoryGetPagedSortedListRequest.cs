using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPhoneDirectoryGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _isEnterpriseInfoRequested;

    [XmlElement(ElementName = "isEnterpriseInfoRequested", IsNullable = false, Namespace = "")]
    public bool IsEnterpriseInfoRequested {
        get => _isEnterpriseInfoRequested;
        set {
            IsEnterpriseInfoRequestedSpecified = true;
            _isEnterpriseInfoRequested = value;
        }
    }

    [XmlIgnore]
    public bool IsEnterpriseInfoRequestedSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

    [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl {
        get => _responsePagingControl;
        set {
            ResponsePagingControlSpecified = true;
            _responsePagingControl = value;
        }
    }

    [XmlIgnore]
    public bool ResponsePagingControlSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName {
        get => _sortByUserLastName;
        set {
            SortByUserLastNameSpecified = true;
            _sortByUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserLastNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName {
        get => _sortByUserFirstName;
        set {
            SortByUserFirstNameSpecified = true;
            _sortByUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserFirstNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByUserDepartment _sortByUserDepartment;

    [XmlElement(ElementName = "sortByUserDepartment", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserDepartment SortByUserDepartment {
        get => _sortByUserDepartment;
        set {
            SortByUserDepartmentSpecified = true;
            _sortByUserDepartment = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserDepartmentSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByReceptionistNote _sortByReceptionistNote;

    [XmlElement(ElementName = "sortByReceptionistNote", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByReceptionistNote SortByReceptionistNote {
        get => _sortByReceptionistNote;
        set {
            SortByReceptionistNoteSpecified = true;
            _sortByReceptionistNote = value;
        }
    }

    [XmlIgnore]
    public bool SortByReceptionistNoteSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName;

    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName {
        get => _searchCriteriaUserLastName;
        set {
            SearchCriteriaUserLastNameSpecified = true;
            _searchCriteriaUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserLastNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName;

    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName {
        get => _searchCriteriaUserFirstName;
        set {
            SearchCriteriaUserFirstNameSpecified = true;
            _searchCriteriaUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserFirstNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserName> _searchCriteriaUserName;

    [XmlElement(ElementName = "searchCriteriaUserName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserName> SearchCriteriaUserName {
        get => _searchCriteriaUserName;
        set {
            SearchCriteriaUserNameSpecified = true;
            _searchCriteriaUserName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn;

    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn {
        get => _searchCriteriaDn;
        set {
            SearchCriteriaDnSpecified = true;
            _searchCriteriaDn = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDnSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> _searchCriteriaGroupLocationCode;

    [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode {
        get => _searchCriteriaGroupLocationCode;
        set {
            SearchCriteriaGroupLocationCodeSpecified = true;
            _searchCriteriaGroupLocationCode = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupLocationCodeSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension;

    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension {
        get => _searchCriteriaExtension;
        set {
            SearchCriteriaExtensionSpecified = true;
            _searchCriteriaExtension = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExtensionSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> _searchCriteriaMobilePhoneNumber;

    [XmlElement(ElementName = "searchCriteriaMobilePhoneNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> SearchCriteriaMobilePhoneNumber {
        get => _searchCriteriaMobilePhoneNumber;
        set {
            SearchCriteriaMobilePhoneNumberSpecified = true;
            _searchCriteriaMobilePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaMobilePhoneNumberSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress;

    [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress {
        get => _searchCriteriaEmailAddress;
        set {
            SearchCriteriaEmailAddressSpecified = true;
            _searchCriteriaEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaEmailAddressSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaYahooId> _searchCriteriaYahooId;

    [XmlElement(ElementName = "searchCriteriaYahooId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaYahooId> SearchCriteriaYahooId {
        get => _searchCriteriaYahooId;
        set {
            SearchCriteriaYahooIdSpecified = true;
            _searchCriteriaYahooId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaYahooIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserGroup _searchCriteriaExactUserGroup;

    [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup {
        get => _searchCriteriaExactUserGroup;
        set {
            SearchCriteriaExactUserGroupSpecified = true;
            _searchCriteriaExactUserGroup = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserGroupSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName;

    [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDepartmentName> SearchCriteriaDepartmentName {
        get => _searchCriteriaDepartmentName;
        set {
            SearchCriteriaDepartmentNameSpecified = true;
            _searchCriteriaDepartmentName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDepartmentNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId;

    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId {
        get => _searchCriteriaUserId;
        set {
            SearchCriteriaUserIdSpecified = true;
            _searchCriteriaUserId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaImpId> _searchCriteriaImpId;

    [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaImpId> SearchCriteriaImpId {
        get => _searchCriteriaImpId;
        set {
            SearchCriteriaImpIdSpecified = true;
            _searchCriteriaImpId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaImpIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaTitle> _searchCriteriaTitle;

    [XmlElement(ElementName = "searchCriteriaTitle", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaTitle> SearchCriteriaTitle {
        get => _searchCriteriaTitle;
        set {
            SearchCriteriaTitleSpecified = true;
            _searchCriteriaTitle = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaTitleSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaReceptionistNote> _searchCriteriaReceptionistNote;

    [XmlElement(ElementName = "searchCriteriaReceptionistNote", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaReceptionistNote> SearchCriteriaReceptionistNote {
        get => _searchCriteriaReceptionistNote;
        set {
            SearchCriteriaReceptionistNoteSpecified = true;
            _searchCriteriaReceptionistNote = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaReceptionistNoteSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaMultiPartUserName> _searchCriteriaMultiPartName;

    [XmlElement(ElementName = "searchCriteriaMultiPartName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaMultiPartUserName> SearchCriteriaMultiPartName {
        get => _searchCriteriaMultiPartName;
        set {
            SearchCriteriaMultiPartNameSpecified = true;
            _searchCriteriaMultiPartName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaMultiPartNameSpecified { get; set; }
}
}
