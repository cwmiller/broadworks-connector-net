using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupCustomContactDirectoryGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName { get; set; }
    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName { get; set; }
    [XmlElement(ElementName = "sortByUserDepartment", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByUserDepartment SortByUserDepartment { get; set; }
    [XmlElement(ElementName = "sortByReceptionistNote", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByReceptionistNote SortByReceptionistNote { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName { get; set; }
    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn { get; set; }
    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension { get; set; }
    [XmlElement(ElementName = "searchCriteriaMobilePhoneNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> SearchCriteriaMobilePhoneNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId { get; set; }
    [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDepartmentName> SearchCriteriaDepartmentName { get; set; }
    [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaImpId> SearchCriteriaImpId { get; set; }
    [XmlElement(ElementName = "searchCriteriaTitle", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaTitle> SearchCriteriaTitle { get; set; }
    [XmlElement(ElementName = "searchCriteriaReceptionistNote", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaReceptionistNote> SearchCriteriaReceptionistNote { get; set; }
 }
}
