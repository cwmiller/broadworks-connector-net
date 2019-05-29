using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseTrunkTrunkGroupKeyList 
{
    [XmlElement(ElementName = "trunkGroupList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroupList { get; set; }
 }
}
