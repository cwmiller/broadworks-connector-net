using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByScheduleName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByScheduleName SortByScheduleName { get; set; }
    [XmlElement(ElementName = "searchCriteriaScheduleName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaScheduleName> SearchCriteriaScheduleName { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactScheduleType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactScheduleType> SearchCriteriaExactScheduleType { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactScheduleLevel", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactScheduleLevel> SearchCriteriaExactScheduleLevel { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
 }
}
