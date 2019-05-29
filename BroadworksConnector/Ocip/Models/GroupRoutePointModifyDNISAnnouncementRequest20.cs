using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyDNISAnnouncementRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "dnisKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DNISKey DnisKey { get; set; }
    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 MediaOnHoldSource { get; set; }
 }
}
