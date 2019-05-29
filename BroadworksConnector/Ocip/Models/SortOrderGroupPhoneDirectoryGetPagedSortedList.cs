using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupPhoneDirectoryGetPagedSortedList 
{
    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName { get; set; }
    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName { get; set; }
    [XmlElement(ElementName = "sortByMobilePhoneNumber", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByMobilePhoneNumber SortByMobilePhoneNumber { get; set; }
    [XmlElement(ElementName = "sortByEmailAddress", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByEmailAddress SortByEmailAddress { get; set; }
    [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDepartmentName SortByDepartmentName { get; set; }
    [XmlElement(ElementName = "sortByYahooId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByYahooId SortByYahooId { get; set; }
    [XmlElement(ElementName = "sortByUserId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserId SortByUserId { get; set; }
    [XmlElement(ElementName = "sortByImpId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByImpId SortByImpId { get; set; }
 }
}
