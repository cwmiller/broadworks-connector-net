using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "securityClassification", IsNullable = false)]
    public string SecurityClassification { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaTrunkGroupName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaTrunkGroupName> SearchCriteriaTrunkGroupName { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType { get; set; }
 }
}
