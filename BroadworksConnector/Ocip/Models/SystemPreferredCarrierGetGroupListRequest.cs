using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetGroupListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "carrier", IsNullable = false)]
    public string Carrier { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupName> SearchCriteriaGroupName { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactServiceProvider", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProvider> SearchCriteriaExactServiceProvider { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId { get; set; }
 }
}
