using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkGetResponseOrderedRouting 
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroup { get; set; }
    [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm OrderingAlgorithm { get; set; }
 }
}
