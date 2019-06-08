using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkModifyRequestOrderedRouting 
{
    private BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList _trunkGroupList;

    [XmlElement(ElementName = "trunkGroupList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList TrunkGroupList {
        get => _trunkGroupList;
        set {
            TrunkGroupListSpecified = true;
            _trunkGroupList = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupListSpecified { get; set; }
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
