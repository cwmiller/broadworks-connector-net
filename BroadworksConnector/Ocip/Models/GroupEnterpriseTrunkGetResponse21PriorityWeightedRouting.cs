using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkGetResponse21PriorityWeightedRouting 
{
    [XmlElement(ElementName = "priorityWeightedTrunkGroup", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> PriorityWeightedTrunkGroup { get; set; }
    [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false)]
    public int MaximumRerouteAttemptsWithinPriority { get; set; }
 }
}
