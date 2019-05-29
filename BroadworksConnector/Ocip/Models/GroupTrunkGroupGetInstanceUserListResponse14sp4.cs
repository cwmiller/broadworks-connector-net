using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceUserListResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "trunkGroupUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TrunkGroupUserTable { get; set; }
 }
}
