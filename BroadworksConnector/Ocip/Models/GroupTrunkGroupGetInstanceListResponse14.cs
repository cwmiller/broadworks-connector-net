using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceListResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "trunkGroupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TrunkGroupTable { get; set; }
 }
}
