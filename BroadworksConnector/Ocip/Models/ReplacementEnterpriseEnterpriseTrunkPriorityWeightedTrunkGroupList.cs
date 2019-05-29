using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseEnterpriseTrunkPriorityWeightedTrunkGroupList 
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkPriorityWeightedTrunkGroup> TrunkGroup { get; set; }
 }
}
