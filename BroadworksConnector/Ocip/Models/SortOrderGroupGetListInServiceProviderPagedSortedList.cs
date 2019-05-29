using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupGetListInServiceProviderPagedSortedList 
{
    [XmlElement(ElementName = "sortByGroupId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByGroupId SortByGroupId { get; set; }
    [XmlElement(ElementName = "sortByGroupName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByGroupName SortByGroupName { get; set; }
 }
}
