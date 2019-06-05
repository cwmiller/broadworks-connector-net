using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseEnterpriseTrunkPriorityWeightedTrunkGroupList 
{
    private List<BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkPriorityWeightedTrunkGroup> _trunkGroup;

    [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkPriorityWeightedTrunkGroup> TrunkGroup {
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
