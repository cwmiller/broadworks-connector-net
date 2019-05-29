using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseUserCallingPlanSettingsGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "callingPlanService", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingPlanService CallingPlanService { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName { get; set; }
    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName { get; set; }
    [XmlElement(ElementName = "sortByUserDepartment", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserDepartment SortByUserDepartment { get; set; }
    [XmlElement(ElementName = "sortByDn", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDn SortByDn { get; set; }
    [XmlElement(ElementName = "sortByExtension", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByExtension SortByExtension { get; set; }
    [XmlElement(ElementName = "sortByGroupId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByGroupId SortByGroupId { get; set; }
    [XmlElement(ElementName = "includeVirtualUsers", IsNullable = false)]
    public bool IncludeVirtualUsers { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId { get; set; }
    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn { get; set; }
    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension { get; set; }
    [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserInTrunkGroup", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserInTrunkGroup SearchCriteriaExactUserInTrunkGroup { get; set; }
 }
}
