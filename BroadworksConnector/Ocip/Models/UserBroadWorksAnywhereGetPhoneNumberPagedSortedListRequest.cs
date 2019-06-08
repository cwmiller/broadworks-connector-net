using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.SortByLocation _sortByLocation;

    [XmlElement(ElementName = "sortByLocation", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByLocation SortByLocation {
        get => _sortByLocation;
        set {
            SortByLocationSpecified = true;
            _sortByLocation = value;
        }
    }

    [XmlIgnore]
    public bool SortByLocationSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByEnabled _sortByEnabled;

    [XmlElement(ElementName = "sortByEnabled", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByEnabled SortByEnabled {
        get => _sortByEnabled;
        set {
            SortByEnabledSpecified = true;
            _sortByEnabled = value;
        }
    }

    [XmlIgnore]
    public bool SortByEnabledSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaLocation> _searchCriteriaLocation;

    [XmlElement(ElementName = "searchCriteriaLocation", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaLocation> SearchCriteriaLocation {
        get => _searchCriteriaLocation;
        set {
            SearchCriteriaLocationSpecified = true;
            _searchCriteriaLocation = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaLocationSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactLocationEnabled _searchCriteriaExactLocationEnabled;

    [XmlElement(ElementName = "searchCriteriaExactLocationEnabled", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactLocationEnabled SearchCriteriaExactLocationEnabled {
        get => _searchCriteriaExactLocationEnabled;
        set {
            SearchCriteriaExactLocationEnabledSpecified = true;
            _searchCriteriaExactLocationEnabled = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactLocationEnabledSpecified { get; set; }
}
}
