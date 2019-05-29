using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "trunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey { get; set; }
    [XmlElement(ElementName = "statusCode", IsNullable = false)]
    public List<string> StatusCode { get; set; }
 }
}
