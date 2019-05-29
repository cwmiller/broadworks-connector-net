using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkGetResponse21PriorityWeightedRouting 
{
    [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false)]
    public int MaximumRerouteAttemptsWithinPriority { get; set; }
    [XmlElement(ElementName = "priorityWeightedTrunkGroup", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkPriorityWeightedTrunkGroup> PriorityWeightedTrunkGroup { get; set; }
 }
}
