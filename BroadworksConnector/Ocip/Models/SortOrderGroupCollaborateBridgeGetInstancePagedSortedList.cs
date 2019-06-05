using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupCollaborateBridgeGetInstancePagedSortedList 
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
}
}
