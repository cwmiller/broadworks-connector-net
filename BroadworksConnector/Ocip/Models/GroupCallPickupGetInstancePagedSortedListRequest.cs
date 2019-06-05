using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallPickupGetInstancePagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SortByCallPickupName _sortByCallPickupName;

    [XmlElement(ElementName = "sortByCallPickupName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByCallPickupName SortByCallPickupName {
        get => _sortByCallPickupName;
        set {
            SortByCallPickupNameSpecified = true;
            _sortByCallPickupName = value;
        }
    }

    [XmlIgnore]
    public bool SortByCallPickupNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaCallPickupName> _searchCriteriaCallPickupName;

    [XmlElement(ElementName = "searchCriteriaCallPickupName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCallPickupName> SearchCriteriaCallPickupName {
        get => _searchCriteriaCallPickupName;
        set {
            SearchCriteriaCallPickupNameSpecified = true;
            _searchCriteriaCallPickupName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaCallPickupNameSpecified { get; set; }
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
