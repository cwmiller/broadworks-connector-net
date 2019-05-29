using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupSecurityClassificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "trunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey { get; set; }
    [XmlElement(ElementName = "defaultSecurityClassification", IsNullable = true)]
    public string DefaultSecurityClassification { get; set; }
 }
}
