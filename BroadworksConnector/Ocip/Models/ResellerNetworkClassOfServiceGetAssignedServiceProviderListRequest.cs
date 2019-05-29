using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerNetworkClassOfServiceGetAssignedServiceProviderListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderName> SearchCriteriaServiceProviderName { get; set; }
 }
}
