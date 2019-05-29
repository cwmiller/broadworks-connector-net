using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupCommonPhoneListGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByGroupCommonPhoneListNumber", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByGroupCommonPhoneListNumber SortByGroupCommonPhoneListNumber { get; set; }
    [XmlElement(ElementName = "sortByGroupCommonPhoneListName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByGroupCommonPhoneListName SortByGroupCommonPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> SearchCriteriaGroupCommonPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> SearchCriteriaGroupCommonPhoneListNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupCommonMultiPartPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonMultiPartPhoneListName> SearchCriteriaGroupCommonMultiPartPhoneListName { get; set; }
 }
}
