using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.SortByScheduleName _sortByScheduleName;

    [XmlElement(ElementName = "sortByScheduleName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByScheduleName SortByScheduleName {
        get => _sortByScheduleName;
        set {
            SortByScheduleNameSpecified = true;
            _sortByScheduleName = value;
        }
    }

    [XmlIgnore]
    public bool SortByScheduleNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaScheduleName> _searchCriteriaScheduleName;

    [XmlElement(ElementName = "searchCriteriaScheduleName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaScheduleName> SearchCriteriaScheduleName {
        get => _searchCriteriaScheduleName;
        set {
            SearchCriteriaScheduleNameSpecified = true;
            _searchCriteriaScheduleName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaScheduleNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleType> _searchCriteriaExactScheduleType;

    [XmlElement(ElementName = "searchCriteriaExactScheduleType", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleType> SearchCriteriaExactScheduleType {
        get => _searchCriteriaExactScheduleType;
        set {
            SearchCriteriaExactScheduleTypeSpecified = true;
            _searchCriteriaExactScheduleType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactScheduleTypeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel> _searchCriteriaExactScheduleLevel;

    [XmlElement(ElementName = "searchCriteriaExactScheduleLevel", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel> SearchCriteriaExactScheduleLevel {
        get => _searchCriteriaExactScheduleLevel;
        set {
            SearchCriteriaExactScheduleLevelSpecified = true;
            _searchCriteriaExactScheduleLevel = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactScheduleLevelSpecified { get; set; }
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
