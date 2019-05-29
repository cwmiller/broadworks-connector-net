using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupCallCenterGetAvailableAgentPagedSortedList 
{
    [XmlElement(ElementName = "sortByUserId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserId SortByUserId { get; set; }
    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName { get; set; }
    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName { get; set; }
    [XmlElement(ElementName = "sortByDn", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDn SortByDn { get; set; }
    [XmlElement(ElementName = "sortByExtension", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByExtension SortByExtension { get; set; }
    [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDepartmentName SortByDepartmentName { get; set; }
    [XmlElement(ElementName = "sortByEmailAddress", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByEmailAddress SortByEmailAddress { get; set; }
 }
}
