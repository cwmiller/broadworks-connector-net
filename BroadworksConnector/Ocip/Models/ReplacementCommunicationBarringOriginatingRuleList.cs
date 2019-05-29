using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringOriginatingRuleList 
{
    [XmlElement(ElementName = "rule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringOriginatingRule> Rule { get; set; }
 }
}
