using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList 
{
    private List<BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> _trunkGroup;

    [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> TrunkGroup {
        get => _trunkGroup;
        set {
            TrunkGroupSpecified = true;
            _trunkGroup = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupSpecified { get; set; }
}
}
