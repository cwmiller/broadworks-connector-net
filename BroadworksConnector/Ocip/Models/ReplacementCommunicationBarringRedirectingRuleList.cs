using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringRedirectingRuleList 
{
    [XmlElement(ElementName = "rule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingRule> Rule { get; set; }
 }
}
