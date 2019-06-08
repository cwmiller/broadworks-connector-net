using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupAdminGetPagedSortedList 
{
    private BroadWorksConnector.Ocip.Models.SortByAdminId _sortByAdminId;

    [XmlElement(ElementName = "sortByAdminId", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByAdminId SortByAdminId {
        get => _sortByAdminId;
        set {
            SortByAdminIdSpecified = true;
            _sortByAdminId = value;
        }
    }

    [XmlIgnore]
    public bool SortByAdminIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByAdminLastName _sortByAdminLastName;

    [XmlElement(ElementName = "sortByAdminLastName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByAdminLastName SortByAdminLastName {
        get => _sortByAdminLastName;
        set {
            SortByAdminLastNameSpecified = true;
            _sortByAdminLastName = value;
        }
    }

    [XmlIgnore]
    public bool SortByAdminLastNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByAdminFirstName _sortByAdminFirstName;

    [XmlElement(ElementName = "sortByAdminFirstName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByAdminFirstName SortByAdminFirstName {
        get => _sortByAdminFirstName;
        set {
            SortByAdminFirstNameSpecified = true;
            _sortByAdminFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SortByAdminFirstNameSpecified { get; set; }
}
}
