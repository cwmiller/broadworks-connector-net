using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderServiceProviderGetPagedSortedList 
{
    [XmlElement(ElementName = "sortByServiceProviderId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByServiceProviderId SortByServiceProviderId { get; set; }
    [XmlElement(ElementName = "sortByServiceProviderName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByServiceProviderName SortByServiceProviderName { get; set; }
 }
}
