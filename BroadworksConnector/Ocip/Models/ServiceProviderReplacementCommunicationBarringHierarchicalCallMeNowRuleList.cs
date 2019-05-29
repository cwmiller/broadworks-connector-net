using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderReplacementCommunicationBarringHierarchicalCallMeNowRuleList 
{
    [XmlElement(ElementName = "rule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalCallMeNowRule> Rule { get; set; }
 }
}
