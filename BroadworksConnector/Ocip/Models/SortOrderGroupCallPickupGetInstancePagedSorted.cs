using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupCallPickupGetInstancePagedSorted 
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
    private BroadworksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName {
        get => _sortByUserLastName;
        set {
            SortByUserLastNameSpecified = true;
            _sortByUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserLastNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName {
        get => _sortByUserFirstName;
        set {
            SortByUserFirstNameSpecified = true;
            _sortByUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserFirstNameSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.SortByEmailAddress _sortByEmailAddress;

    [XmlElement(ElementName = "sortByEmailAddress", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByEmailAddress SortByEmailAddress {
        get => _sortByEmailAddress;
        set {
            SortByEmailAddressSpecified = true;
            _sortByEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool SortByEmailAddressSpecified { get; set; }
}
}
