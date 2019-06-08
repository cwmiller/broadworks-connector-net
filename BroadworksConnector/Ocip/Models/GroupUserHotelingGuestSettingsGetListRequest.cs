using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupUserHotelingGuestSettingsGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByUserLastName SortByUserLastName {
        get => _sortByUserLastName;
        set {
            SortByUserLastNameSpecified = true;
            _sortByUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserLastNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName {
        get => _sortByUserFirstName;
        set {
            SortByUserFirstNameSpecified = true;
            _sortByUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserFirstNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByUserDepartment _sortByUserDepartment;

    [XmlElement(ElementName = "sortByUserDepartment", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByUserDepartment SortByUserDepartment {
        get => _sortByUserDepartment;
        set {
            SortByUserDepartmentSpecified = true;
            _sortByUserDepartment = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserDepartmentSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByDn _sortByDn;

    [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByDn SortByDn {
        get => _sortByDn;
        set {
            SortByDnSpecified = true;
            _sortByDn = value;
        }
    }

    [XmlIgnore]
    public bool SortByDnSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByExtension _sortByExtension;

    [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByExtension SortByExtension {
        get => _sortByExtension;
        set {
            SortByExtensionSpecified = true;
            _sortByExtension = value;
        }
    }

    [XmlIgnore]
    public bool SortByExtensionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByServiceStatus _sortByServiceStatus;

    [XmlElement(ElementName = "sortByServiceStatus", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByServiceStatus SortByServiceStatus {
        get => _sortByServiceStatus;
        set {
            SortByServiceStatusSpecified = true;
            _sortByServiceStatus = value;
        }
    }

    [XmlIgnore]
    public bool SortByServiceStatusSpecified { get; set; }
    private bool _includeVirtualUsers;

    [XmlElement(ElementName = "includeVirtualUsers", IsNullable = false, Namespace = "")]
    public bool IncludeVirtualUsers {
        get => _includeVirtualUsers;
        set {
            IncludeVirtualUsersSpecified = true;
            _includeVirtualUsers = value;
        }
    }

    [XmlIgnore]
    public bool IncludeVirtualUsersSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment {
        get => _searchCriteriaExactUserDepartment;
        set {
            SearchCriteriaExactUserDepartmentSpecified = true;
            _searchCriteriaExactUserDepartment = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserDepartmentSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup _searchCriteriaExactUserInTrunkGroup;

    [XmlElement(ElementName = "searchCriteriaExactUserInTrunkGroup", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup SearchCriteriaExactUserInTrunkGroup {
        get => _searchCriteriaExactUserInTrunkGroup;
        set {
            SearchCriteriaExactUserInTrunkGroupSpecified = true;
            _searchCriteriaExactUserInTrunkGroup = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserInTrunkGroupSpecified { get; set; }
}
}
