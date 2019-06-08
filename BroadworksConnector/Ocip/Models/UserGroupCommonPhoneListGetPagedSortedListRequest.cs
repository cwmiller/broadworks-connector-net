using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupCommonPhoneListGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListNumber _sortByGroupCommonPhoneListNumber;

    [XmlElement(ElementName = "sortByGroupCommonPhoneListNumber", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListNumber SortByGroupCommonPhoneListNumber {
        get => _sortByGroupCommonPhoneListNumber;
        set {
            SortByGroupCommonPhoneListNumberSpecified = true;
            _sortByGroupCommonPhoneListNumber = value;
        }
    }

    [XmlIgnore]
    public bool SortByGroupCommonPhoneListNumberSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListName _sortByGroupCommonPhoneListName;

    [XmlElement(ElementName = "sortByGroupCommonPhoneListName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByGroupCommonPhoneListName SortByGroupCommonPhoneListName {
        get => _sortByGroupCommonPhoneListName;
        set {
            SortByGroupCommonPhoneListNameSpecified = true;
            _sortByGroupCommonPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SortByGroupCommonPhoneListNameSpecified { get; set; }
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> _searchCriteriaGroupCommonPhoneListName;

    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> SearchCriteriaGroupCommonPhoneListName {
        get => _searchCriteriaGroupCommonPhoneListName;
        set {
            SearchCriteriaGroupCommonPhoneListNameSpecified = true;
            _searchCriteriaGroupCommonPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupCommonPhoneListNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> _searchCriteriaGroupCommonPhoneListNumber;

    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListNumber", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> SearchCriteriaGroupCommonPhoneListNumber {
        get => _searchCriteriaGroupCommonPhoneListNumber;
        set {
            SearchCriteriaGroupCommonPhoneListNumberSpecified = true;
            _searchCriteriaGroupCommonPhoneListNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupCommonPhoneListNumberSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonMultiPartPhoneListName> _searchCriteriaGroupCommonMultiPartPhoneListName;

    [XmlElement(ElementName = "searchCriteriaGroupCommonMultiPartPhoneListName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonMultiPartPhoneListName> SearchCriteriaGroupCommonMultiPartPhoneListName {
        get => _searchCriteriaGroupCommonMultiPartPhoneListName;
        set {
            SearchCriteriaGroupCommonMultiPartPhoneListNameSpecified = true;
            _searchCriteriaGroupCommonMultiPartPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupCommonMultiPartPhoneListNameSpecified { get; set; }
}
}
