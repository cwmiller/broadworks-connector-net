using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterprisePhoneDirectoryGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _enterpriseId;

    [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
    public string EnterpriseId {
        get => _enterpriseId;
        set {
            EnterpriseIdSpecified = true;
            _enterpriseId = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseIdSpecified { get; set; }
    private bool _isExtendedInfoRequested;

    [XmlElement(ElementName = "isExtendedInfoRequested", IsNullable = false, Namespace = "")]
    public bool IsExtendedInfoRequested {
        get => _isExtendedInfoRequested;
        set {
            IsExtendedInfoRequestedSpecified = true;
            _isExtendedInfoRequested = value;
        }
    }

    [XmlIgnore]
    public bool IsExtendedInfoRequestedSpecified { get; set; }
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
    private List<BroadWorksConnector.Ocip.Models.SortOrderEnterprisePhoneDirectoryGetPagedSortedList> _sortOrder;

    [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SortOrderEnterprisePhoneDirectoryGetPagedSortedList> SortOrder {
        get => _sortOrder;
        set {
            SortOrderSpecified = true;
            _sortOrder = value;
        }
    }

    [XmlIgnore]
    public bool SortOrderSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName;

    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName {
        get => _searchCriteriaUserLastName;
        set {
            SearchCriteriaUserLastNameSpecified = true;
            _searchCriteriaUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserLastNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName;

    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName {
        get => _searchCriteriaUserFirstName;
        set {
            SearchCriteriaUserFirstNameSpecified = true;
            _searchCriteriaUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserFirstNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn;

    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn {
        get => _searchCriteriaDn;
        set {
            SearchCriteriaDnSpecified = true;
            _searchCriteriaDn = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDnSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> _searchCriteriaGroupLocationCode;

    [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode {
        get => _searchCriteriaGroupLocationCode;
        set {
            SearchCriteriaGroupLocationCodeSpecified = true;
            _searchCriteriaGroupLocationCode = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupLocationCodeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension;

    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension {
        get => _searchCriteriaExtension;
        set {
            SearchCriteriaExtensionSpecified = true;
            _searchCriteriaExtension = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExtensionSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> _searchCriteriaMobilePhoneNumber;

    [XmlElement(ElementName = "searchCriteriaMobilePhoneNumber", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> SearchCriteriaMobilePhoneNumber {
        get => _searchCriteriaMobilePhoneNumber;
        set {
            SearchCriteriaMobilePhoneNumberSpecified = true;
            _searchCriteriaMobilePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaMobilePhoneNumberSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress;

    [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress {
        get => _searchCriteriaEmailAddress;
        set {
            SearchCriteriaEmailAddressSpecified = true;
            _searchCriteriaEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaEmailAddressSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment> _searchCriteriaExactUserDepartment;

    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment> SearchCriteriaExactUserDepartment {
        get => _searchCriteriaExactUserDepartment;
        set {
            SearchCriteriaExactUserDepartmentSpecified = true;
            _searchCriteriaExactUserDepartment = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserDepartmentSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName;

    [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> SearchCriteriaDepartmentName {
        get => _searchCriteriaDepartmentName;
        set {
            SearchCriteriaDepartmentNameSpecified = true;
            _searchCriteriaDepartmentName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDepartmentNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup> _searchCriteriaExactUserGroup;

    [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup> SearchCriteriaExactUserGroup {
        get => _searchCriteriaExactUserGroup;
        set {
            SearchCriteriaExactUserGroupSpecified = true;
            _searchCriteriaExactUserGroup = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserGroupSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName> _searchCriteriaGroupName;

    [XmlElement(ElementName = "searchCriteriaGroupName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName> SearchCriteriaGroupName {
        get => _searchCriteriaGroupName;
        set {
            SearchCriteriaGroupNameSpecified = true;
            _searchCriteriaGroupName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId> _searchCriteriaYahooId;

    [XmlElement(ElementName = "searchCriteriaYahooId", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaYahooId> SearchCriteriaYahooId {
        get => _searchCriteriaYahooId;
        set {
            SearchCriteriaYahooIdSpecified = true;
            _searchCriteriaYahooId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaYahooIdSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId;

    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId {
        get => _searchCriteriaUserId;
        set {
            SearchCriteriaUserIdSpecified = true;
            _searchCriteriaUserId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserIdSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> _searchCriteriaImpId;

    [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> SearchCriteriaImpId {
        get => _searchCriteriaImpId;
        set {
            SearchCriteriaImpIdSpecified = true;
            _searchCriteriaImpId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaImpIdSpecified { get; set; }
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
}
}
