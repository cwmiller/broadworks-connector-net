using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupCallCenterGetInstancePagedSortedList 
{
    [XmlElement(ElementName = "sortByUserId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserId SortByUserId { get; set; }
    [XmlElement(ElementName = "sortByCallCenterName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByCallCenterName SortByCallCenterName { get; set; }
    [XmlElement(ElementName = "sortByDn", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDn SortByDn { get; set; }
    [XmlElement(ElementName = "sortByExtension", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByExtension SortByExtension { get; set; }
    [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDepartmentName SortByDepartmentName { get; set; }
    [XmlElement(ElementName = "sortByHuntPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByHuntPolicy SortByHuntPolicy { get; set; }
    [XmlElement(ElementName = "sortByCallCenterType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByCallCenterType SortByCallCenterType { get; set; }
 }
}
