using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementGroupEnterpriseTrunkTrunkGroupList 
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public List<string> TrunkGroup { get; set; }
 }
}
