using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortOrder", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SortOrderServiceProviderAdminGetPagedSortedList> SortOrder { get; set; }
    [XmlElement(ElementName = "searchCriteriaAdminId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminId> SearchCriteriaAdminId { get; set; }
    [XmlElement(ElementName = "searchCriteriaAdminLastName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminLastName> SearchCriteriaAdminLastName { get; set; }
    [XmlElement(ElementName = "searchCriteriaAdminFirstName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminFirstName> SearchCriteriaAdminFirstName { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactServiceProviderAdminType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProviderAdminType> SearchCriteriaExactServiceProviderAdminType { get; set; }
    [XmlElement(ElementName = "searchCriteriaLanguage", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaLanguage> SearchCriteriaLanguage { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
 }
}
