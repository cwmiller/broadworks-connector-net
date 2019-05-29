using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderServiceProviderAdminGetPagedSortedList 
{
    [XmlElement(ElementName = "sortByAdminId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByAdminId SortByAdminId { get; set; }
    [XmlElement(ElementName = "sortByAdminLastName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByAdminLastName SortByAdminLastName { get; set; }
    [XmlElement(ElementName = "sortByAdminFirstName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByAdminFirstName SortByAdminFirstName { get; set; }
 }
}
