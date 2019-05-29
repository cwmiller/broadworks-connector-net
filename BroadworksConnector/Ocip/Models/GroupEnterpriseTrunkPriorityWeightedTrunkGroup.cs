using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkPriorityWeightedTrunkGroup 
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public string TrunkGroup { get; set; }
    [XmlElement(ElementName = "priority", IsNullable = false)]
    public int Priority { get; set; }
    [XmlElement(ElementName = "weight", IsNullable = false)]
    public int Weight { get; set; }
 }
}
