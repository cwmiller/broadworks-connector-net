using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNGetPolicyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactPolicySelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactPolicySelection SearchCriteriaExactPolicySelection { get; set; }
 }
}
