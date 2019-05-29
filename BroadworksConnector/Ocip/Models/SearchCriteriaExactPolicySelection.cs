using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactPolicySelection : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "policySelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection PolicySelection { get; set; }
 }
}
