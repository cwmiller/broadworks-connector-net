using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderServiceProviderGetPagedSortedList 
{
    private BroadWorksConnector.Ocip.Models.SortByServiceProviderId _sortByServiceProviderId;

    [XmlElement(ElementName = "sortByServiceProviderId", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByServiceProviderId SortByServiceProviderId {
        get => _sortByServiceProviderId;
        set {
            SortByServiceProviderIdSpecified = true;
            _sortByServiceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SortByServiceProviderIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SortByServiceProviderName _sortByServiceProviderName;

    [XmlElement(ElementName = "sortByServiceProviderName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SortByServiceProviderName SortByServiceProviderName {
        get => _sortByServiceProviderName;
        set {
            SortByServiceProviderNameSpecified = true;
            _sortByServiceProviderName = value;
        }
    }

    [XmlIgnore]
    public bool SortByServiceProviderNameSpecified { get; set; }
}
}
