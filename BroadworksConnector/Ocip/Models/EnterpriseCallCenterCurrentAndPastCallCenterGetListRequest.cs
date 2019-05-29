using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "isPremiumOnly", IsNullable = false)]
    public bool IsPremiumOnly { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup { get; set; }
    [XmlElement(ElementName = "searchCriteriaCallCenterName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterName SearchCriteriaCallCenterName { get; set; }
 }
}
