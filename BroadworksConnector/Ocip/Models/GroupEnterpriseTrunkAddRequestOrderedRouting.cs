using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkAddRequestOrderedRouting 
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public List<string> TrunkGroup { get; set; }
    [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm OrderingAlgorithm { get; set; }
 }
}
