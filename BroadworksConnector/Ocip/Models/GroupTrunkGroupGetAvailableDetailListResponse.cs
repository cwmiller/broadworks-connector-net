using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetAvailableDetailListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup> TrunkGroup { get; set; }
 }
}
