using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting 
{
    [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false)]
    public int MaximumRerouteAttemptsWithinPriority { get; set; }
    [XmlElement(ElementName = "priorityWeightedTrunkGroupList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList PriorityWeightedTrunkGroupList { get; set; }
 }
}
