using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkAddRequestOrderedRouting 
{
    private List<string> _trunkGroup;

    [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
    public List<string> TrunkGroup {
        get => _trunkGroup;
        set {
            TrunkGroupSpecified = true;
            _trunkGroup = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm _orderingAlgorithm;

    [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm OrderingAlgorithm {
        get => _orderingAlgorithm;
        set {
            OrderingAlgorithmSpecified = true;
            _orderingAlgorithm = value;
        }
    }

    [XmlIgnore]
    public bool OrderingAlgorithmSpecified { get; set; }
}
}
