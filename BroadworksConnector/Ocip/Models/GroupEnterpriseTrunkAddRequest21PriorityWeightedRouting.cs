using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkAddRequest21PriorityWeightedRouting 
{
    private int _maximumRerouteAttemptsWithinPriority;

    [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false, Namespace = "")]
    public int MaximumRerouteAttemptsWithinPriority {
        get => _maximumRerouteAttemptsWithinPriority;
        set {
            MaximumRerouteAttemptsWithinPrioritySpecified = true;
            _maximumRerouteAttemptsWithinPriority = value;
        }
    }

    [XmlIgnore]
    public bool MaximumRerouteAttemptsWithinPrioritySpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> _priorityWeightedTrunkGroup;

    [XmlElement(ElementName = "priorityWeightedTrunkGroup", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> PriorityWeightedTrunkGroup {
        get => _priorityWeightedTrunkGroup;
        set {
            PriorityWeightedTrunkGroupSpecified = true;
            _priorityWeightedTrunkGroup = value;
        }
    }

    [XmlIgnore]
    public bool PriorityWeightedTrunkGroupSpecified { get; set; }
}
}
