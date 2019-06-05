using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseTrunkTrunkGroupKeyList 
{
    private List<BroadworksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> _trunkGroupList;

    [XmlElement(ElementName = "trunkGroupList", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroupList {
        get => _trunkGroupList;
        set {
            TrunkGroupListSpecified = true;
            _trunkGroupList = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupListSpecified { get; set; }
}
}
