using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderReplacementCommunicationBarringHierarchicalRedirectingRuleList 
{
    [XmlElement(ElementName = "rule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ServiceProviderCommunicationBarringHierarchicalRedirectingRule> Rule { get; set; }
 }
}
