using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetListInServiceProviderPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.SortOrderGroupGetListInServiceProviderPagedSortedList> _sortOrder;

    [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SortOrderGroupGetListInServiceProviderPagedSortedList> SortOrder {
        get => _sortOrder;
        set {
            SortOrderSpecified = true;
            _sortOrder = value;
        }
    }

    [XmlIgnore]
    public bool SortOrderSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
        get => _searchCriteriaGroupId;
        set {
            SearchCriteriaGroupIdSpecified = true;
            _searchCriteriaGroupId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupName> _searchCriteriaGroupName;

    [XmlElement(ElementName = "searchCriteriaGroupName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupName> SearchCriteriaGroupName {
        get => _searchCriteriaGroupName;
        set {
            SearchCriteriaGroupNameSpecified = true;
            _searchCriteriaGroupName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupNameSpecified { get; set; }
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
