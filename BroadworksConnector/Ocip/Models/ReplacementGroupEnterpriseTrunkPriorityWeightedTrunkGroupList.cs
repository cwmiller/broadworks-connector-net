using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList 
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> TrunkGroup { get; set; }
 }
}
