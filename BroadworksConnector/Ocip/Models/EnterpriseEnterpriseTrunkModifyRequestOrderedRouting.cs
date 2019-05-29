using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkModifyRequestOrderedRouting 
{
    [XmlElement(ElementName = "trunkGroupList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList TrunkGroupList { get; set; }
    [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm OrderingAlgorithm { get; set; }
 }
}
