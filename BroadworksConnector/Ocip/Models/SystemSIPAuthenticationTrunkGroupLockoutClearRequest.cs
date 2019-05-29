using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAuthenticationTrunkGroupLockoutClearRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "trunkGroupkey", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.TrunkGroupKey> TrunkGroupkey { get; set; }
 }
}
