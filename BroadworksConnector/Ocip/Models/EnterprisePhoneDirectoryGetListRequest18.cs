using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterprisePhoneDirectoryGetListRequest18 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enterpriseId", IsNullable = false)]
    public string EnterpriseId { get; set; }
    [XmlElement(ElementName = "isExtendedInfoRequested", IsNullable = false)]
    public bool IsExtendedInfoRequested { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName { get; set; }
    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode { get; set; }
    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension { get; set; }
    [XmlElement(ElementName = "searchCriteriaMobilePhoneNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaMobilePhoneNumber> SearchCriteriaMobilePhoneNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaYahooId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaYahooId> SearchCriteriaYahooId { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId { get; set; }
    [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaImpId> SearchCriteriaImpId { get; set; }
 }
}
