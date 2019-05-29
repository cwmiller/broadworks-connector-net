using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnterpriseCommonPhoneListGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListNumber", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListNumber SortByEnterpriseCommonPhoneListNumber { get; set; }
    [XmlElement(ElementName = "sortByEnterpriseCommonPhoneListName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByEnterpriseCommonPhoneListName SortByEnterpriseCommonPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
    [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> SearchCriteriaEnterpriseCommonPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> SearchCriteriaEnterpriseCommonPhoneListNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaEnterpriseCommonMultiPartPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonMultiPartPhoneListName> SearchCriteriaEnterpriseCommonMultiPartPhoneListName { get; set; }
 }
}
