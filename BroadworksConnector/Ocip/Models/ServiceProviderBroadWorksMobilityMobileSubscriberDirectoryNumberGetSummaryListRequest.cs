using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaMobileSubscriberDirectoryNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> SearchCriteriaMobileSubscriberDirectoryNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactMobileNetwork", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork SearchCriteriaExactMobileNetwork { get; set; }
 }
}
