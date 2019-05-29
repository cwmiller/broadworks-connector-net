using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalPhoneListGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByUserPersonalPhoneListNumber", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserPersonalPhoneListNumber SortByUserPersonalPhoneListNumber { get; set; }
    [XmlElement(ElementName = "sortByUserPersonalPhoneListName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserPersonalPhoneListName SortByUserPersonalPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> SearchCriteriaUserPersonalPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> SearchCriteriaUserPersonalPhoneListNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserPersonalMultiPartPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalMultiPartPhoneListName> SearchCriteriaUserPersonalMultiPartPhoneListName { get; set; }
 }
}
