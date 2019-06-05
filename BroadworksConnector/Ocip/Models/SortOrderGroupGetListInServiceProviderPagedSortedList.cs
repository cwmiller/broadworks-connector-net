using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupGetListInServiceProviderPagedSortedList 
{
    private BroadworksConnector.Ocip.Models.SortByGroupId _sortByGroupId;

    [XmlElement(ElementName = "sortByGroupId", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByGroupId SortByGroupId {
        get => _sortByGroupId;
        set {
            SortByGroupIdSpecified = true;
            _sortByGroupId = value;
        }
    }

    [XmlIgnore]
    public bool SortByGroupIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByGroupName _sortByGroupName;

    [XmlElement(ElementName = "sortByGroupName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByGroupName SortByGroupName {
        get => _sortByGroupName;
        set {
            SortByGroupNameSpecified = true;
            _sortByGroupName = value;
        }
    }

    [XmlIgnore]
    public bool SortByGroupNameSpecified { get; set; }
}
}
