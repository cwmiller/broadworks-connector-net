using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringIncomingRuleList19sp1 
{
    [XmlElement(ElementName = "rule", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> Rule { get; set; }
 }
}
