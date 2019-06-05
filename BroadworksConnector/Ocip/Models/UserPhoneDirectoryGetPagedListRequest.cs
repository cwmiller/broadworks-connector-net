using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPhoneDirectoryGetPagedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment {
        get => _searchCriteriaExactUserDepartment;
        set {
            SearchCriteriaExactUserDepartmentSpecified = true;
            _searchCriteriaExactUserDepartment = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserDepartmentSpecified { get; set; }
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
    private bool _sortByFirstName;

    [XmlElement(ElementName = "sortByFirstName", IsNullable = false, Namespace = "")]
    public bool SortByFirstName {
        get => _sortByFirstName;
        set {
            SortByFirstNameSpecified = true;
            _sortByFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SortByFirstNameSpecified { get; set; }
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
}
}
