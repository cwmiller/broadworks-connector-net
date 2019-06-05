using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterGetAvailableCallCenterPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SortByUserId _sortByUserId;

    [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserId SortByUserId {
        get => _sortByUserId;
        set {
            SortByUserIdSpecified = true;
            _sortByUserId = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserIdSpecified { get; set; }
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
