using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostGetInstanceListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "groupDepartmentName", IsNullable = false)]
    public string GroupDepartmentName { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceInstanceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceInstanceName> SearchCriteriaServiceInstanceName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId { get; set; }
    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn { get; set; }
    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension { get; set; }
 }
}
