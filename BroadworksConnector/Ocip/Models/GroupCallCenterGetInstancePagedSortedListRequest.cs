using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetInstancePagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.SortOrderGroupCallCenterGetInstancePagedSortedList> _sortOrder;

    [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SortOrderGroupCallCenterGetInstancePagedSortedList> SortOrder {
        get => _sortOrder;
        set {
            SortOrderSpecified = true;
            _sortOrder = value;
        }
    }

    [XmlIgnore]
    public bool SortOrderSpecified { get; set; }
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName> _searchCriteriaCallCenterName;

    [XmlElement(ElementName = "searchCriteriaCallCenterName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName> SearchCriteriaCallCenterName {
        get => _searchCriteriaCallCenterName;
        set {
            SearchCriteriaCallCenterNameSpecified = true;
            _searchCriteriaCallCenterName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaCallCenterNameSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.SearchCriteriaServiceStatus _searchCriteriaServiceStatus;

    [XmlElement(ElementName = "searchCriteriaServiceStatus", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaServiceStatus SearchCriteriaServiceStatus {
        get => _searchCriteriaServiceStatus;
        set {
            SearchCriteriaServiceStatusSpecified = true;
            _searchCriteriaServiceStatus = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceStatusSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactHuntPolicy> _searchCriteriaExactHuntPolicy;

    [XmlElement(ElementName = "searchCriteriaExactHuntPolicy", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactHuntPolicy> SearchCriteriaExactHuntPolicy {
        get => _searchCriteriaExactHuntPolicy;
        set {
            SearchCriteriaExactHuntPolicySpecified = true;
            _searchCriteriaExactHuntPolicy = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactHuntPolicySpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterType> _searchCriteriaExactCallCenterType;

    [XmlElement(ElementName = "searchCriteriaExactCallCenterType", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterType> SearchCriteriaExactCallCenterType {
        get => _searchCriteriaExactCallCenterType;
        set {
            SearchCriteriaExactCallCenterTypeSpecified = true;
            _searchCriteriaExactCallCenterType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactCallCenterTypeSpecified { get; set; }
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
