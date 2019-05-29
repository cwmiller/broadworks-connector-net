using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortOrder", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SortOrderServiceProviderGetPagedSortedList> SortOrder { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderName> SearchCriteriaServiceProviderName { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType { get; set; }
    [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
 }
}
