using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting 
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
    private BroadworksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList _priorityWeightedTrunkGroupList;

    [XmlElement(ElementName = "priorityWeightedTrunkGroupList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList PriorityWeightedTrunkGroupList {
        get => _priorityWeightedTrunkGroupList;
        set {
            PriorityWeightedTrunkGroupListSpecified = true;
            _priorityWeightedTrunkGroupList = value;
        }
    }

    [XmlIgnore]
    public bool PriorityWeightedTrunkGroupListSpecified { get; set; }
}
}
