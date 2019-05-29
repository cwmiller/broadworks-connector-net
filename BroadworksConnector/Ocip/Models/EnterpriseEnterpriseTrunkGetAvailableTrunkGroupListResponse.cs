using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "trunkGroup", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroup { get; set; }
 }
}
