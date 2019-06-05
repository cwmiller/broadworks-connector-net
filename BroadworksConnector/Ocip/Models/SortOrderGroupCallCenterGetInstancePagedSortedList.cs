using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupCallCenterGetInstancePagedSortedList 
{
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
    private BroadworksConnector.Ocip.Models.SortByCallCenterName _sortByCallCenterName;

    [XmlElement(ElementName = "sortByCallCenterName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByCallCenterName SortByCallCenterName {
        get => _sortByCallCenterName;
        set {
            SortByCallCenterNameSpecified = true;
            _sortByCallCenterName = value;
        }
    }

    [XmlIgnore]
    public bool SortByCallCenterNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByDn _sortByDn;

    [XmlElement(ElementName = "sortByDn", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByDn SortByDn {
        get => _sortByDn;
        set {
            SortByDnSpecified = true;
            _sortByDn = value;
        }
    }

    [XmlIgnore]
    public bool SortByDnSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByExtension _sortByExtension;

    [XmlElement(ElementName = "sortByExtension", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByExtension SortByExtension {
        get => _sortByExtension;
        set {
            SortByExtensionSpecified = true;
            _sortByExtension = value;
        }
    }

    [XmlIgnore]
    public bool SortByExtensionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByDepartmentName _sortByDepartmentName;

    [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByDepartmentName SortByDepartmentName {
        get => _sortByDepartmentName;
        set {
            SortByDepartmentNameSpecified = true;
            _sortByDepartmentName = value;
        }
    }

    [XmlIgnore]
    public bool SortByDepartmentNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByHuntPolicy _sortByHuntPolicy;

    [XmlElement(ElementName = "sortByHuntPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByHuntPolicy SortByHuntPolicy {
        get => _sortByHuntPolicy;
        set {
            SortByHuntPolicySpecified = true;
            _sortByHuntPolicy = value;
        }
    }

    [XmlIgnore]
    public bool SortByHuntPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByCallCenterType _sortByCallCenterType;

    [XmlElement(ElementName = "sortByCallCenterType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByCallCenterType SortByCallCenterType {
        get => _sortByCallCenterType;
        set {
            SortByCallCenterTypeSpecified = true;
            _sortByCallCenterType = value;
        }
    }

    [XmlIgnore]
    public bool SortByCallCenterTypeSpecified { get; set; }
}
}
