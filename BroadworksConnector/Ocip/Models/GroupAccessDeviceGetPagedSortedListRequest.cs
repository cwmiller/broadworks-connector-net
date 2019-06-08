using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.SortByDeviceName _sortByDeviceName;

    [XmlElement(ElementName = "sortByDeviceName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByDeviceName SortByDeviceName {
        get => _sortByDeviceName;
        set {
            SortByDeviceNameSpecified = true;
            _sortByDeviceName = value;
        }
    }

    [XmlIgnore]
    public bool SortByDeviceNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByDeviceType _sortByDeviceType;

    [XmlElement(ElementName = "sortByDeviceType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByDeviceType SortByDeviceType {
        get => _sortByDeviceType;
        set {
            SortByDeviceTypeSpecified = true;
            _sortByDeviceType = value;
        }
    }

    [XmlIgnore]
    public bool SortByDeviceTypeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByDeviceNetAddress _sortByDeviceNetAddress;

    [XmlElement(ElementName = "sortByDeviceNetAddress", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByDeviceNetAddress SortByDeviceNetAddress {
        get => _sortByDeviceNetAddress;
        set {
            SortByDeviceNetAddressSpecified = true;
            _sortByDeviceNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SortByDeviceNetAddressSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByDeviceMACAddress _sortByDeviceMACAddress;

    [XmlElement(ElementName = "sortByDeviceMACAddress", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByDeviceMACAddress SortByDeviceMACAddress {
        get => _sortByDeviceMACAddress;
        set {
            SortByDeviceMACAddressSpecified = true;
            _sortByDeviceMACAddress = value;
        }
    }

    [XmlIgnore]
    public bool SortByDeviceMACAddressSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName> _searchCriteriaDeviceName;

    [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName {
        get => _searchCriteriaDeviceName;
        set {
            SearchCriteriaDeviceNameSpecified = true;
            _searchCriteriaDeviceName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> _searchCriteriaDeviceMACAddress;

    [XmlElement(ElementName = "searchCriteriaDeviceMACAddress", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> SearchCriteriaDeviceMACAddress {
        get => _searchCriteriaDeviceMACAddress;
        set {
            SearchCriteriaDeviceMACAddressSpecified = true;
            _searchCriteriaDeviceMACAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceMACAddressSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> _searchCriteriaDeviceNetAddress;

    [XmlElement(ElementName = "searchCriteriaDeviceNetAddress", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> SearchCriteriaDeviceNetAddress {
        get => _searchCriteriaDeviceNetAddress;
        set {
            SearchCriteriaDeviceNetAddressSpecified = true;
            _searchCriteriaDeviceNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceNetAddressSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceType> _searchCriteriaExactDeviceType;

    [XmlElement(ElementName = "searchCriteriaExactDeviceType", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceType> SearchCriteriaExactDeviceType {
        get => _searchCriteriaExactDeviceType;
        set {
            SearchCriteriaExactDeviceTypeSpecified = true;
            _searchCriteriaExactDeviceType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactDeviceTypeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion> _searchCriteriaAccessDeviceVersion;

    [XmlElement(ElementName = "searchCriteriaAccessDeviceVersion", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion> SearchCriteriaAccessDeviceVersion {
        get => _searchCriteriaAccessDeviceVersion;
        set {
            SearchCriteriaAccessDeviceVersionSpecified = true;
            _searchCriteriaAccessDeviceVersion = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaAccessDeviceVersionSpecified { get; set; }
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
