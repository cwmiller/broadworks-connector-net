using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _excludeAgentsAssignedToProfileName;

    [XmlElement(ElementName = "excludeAgentsAssignedToProfileName", IsNullable = false, Namespace = "")]
    public string ExcludeAgentsAssignedToProfileName {
        get => _excludeAgentsAssignedToProfileName;
        set {
            ExcludeAgentsAssignedToProfileNameSpecified = true;
            _excludeAgentsAssignedToProfileName = value;
        }
    }

    [XmlIgnore]
    public bool ExcludeAgentsAssignedToProfileNameSpecified { get; set; }
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
    private List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedList> _sortOrder;

    [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SortOrderEnterpriseCallCenterAgentThresholdProfileGetAvailableAgentPagedSortedList> SortOrder {
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAgentThresholdProfile> _searchCriteriaAgentThresholdProfile;

    [XmlElement(ElementName = "searchCriteriaAgentThresholdProfile", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAgentThresholdProfile> SearchCriteriaAgentThresholdProfile {
        get => _searchCriteriaAgentThresholdProfile;
        set {
            SearchCriteriaAgentThresholdProfileSpecified = true;
            _searchCriteriaAgentThresholdProfile = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaAgentThresholdProfileSpecified { get; set; }
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
