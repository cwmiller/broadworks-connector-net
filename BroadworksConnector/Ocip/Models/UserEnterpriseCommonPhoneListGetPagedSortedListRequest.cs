using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnterpriseCommonPhoneListGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber _sortByEnterpriseCommonPhoneListNumber;

    [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber SortByEnterpriseCommonPhoneListNumber {
        get => _sortByEnterpriseCommonPhoneListNumber;
        set {
            SortByEnterpriseCommonPhoneListNumberSpecified = true;
            _sortByEnterpriseCommonPhoneListNumber = value;
        }
    }

    [XmlIgnore]
    public bool SortByEnterpriseCommonPhoneListNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName _sortByEnterpriseCommonPhoneListName;

    [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName SortByEnterpriseCommonPhoneListName {
        get => _sortByEnterpriseCommonPhoneListName;
        set {
            SortByEnterpriseCommonPhoneListNameSpecified = true;
            _sortByEnterpriseCommonPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SortByEnterpriseCommonPhoneListNameSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> _searchCriteriaEnterpriseCommonPhoneListName;

    [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> SearchCriteriaEnterpriseCommonPhoneListName {
        get => _searchCriteriaEnterpriseCommonPhoneListName;
        set {
            SearchCriteriaEnterpriseCommonPhoneListNameSpecified = true;
            _searchCriteriaEnterpriseCommonPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaEnterpriseCommonPhoneListNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> _searchCriteriaEnterpriseCommonPhoneListNumber;

    [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> SearchCriteriaEnterpriseCommonPhoneListNumber {
        get => _searchCriteriaEnterpriseCommonPhoneListNumber;
        set {
            SearchCriteriaEnterpriseCommonPhoneListNumberSpecified = true;
            _searchCriteriaEnterpriseCommonPhoneListNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaEnterpriseCommonPhoneListNumberSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName> _searchCriteriaEnterpriseCommonMultiPartPhoneListName;

    [XmlElement(ElementName = "searchCriteriaEnterpriseCommonMultiPartPhoneListName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName> SearchCriteriaEnterpriseCommonMultiPartPhoneListName {
        get => _searchCriteriaEnterpriseCommonMultiPartPhoneListName;
        set {
            SearchCriteriaEnterpriseCommonMultiPartPhoneListNameSpecified = true;
            _searchCriteriaEnterpriseCommonMultiPartPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaEnterpriseCommonMultiPartPhoneListNameSpecified { get; set; }
}
}
