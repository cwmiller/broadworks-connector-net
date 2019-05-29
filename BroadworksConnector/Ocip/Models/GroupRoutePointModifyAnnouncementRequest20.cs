using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyAnnouncementRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 MediaOnHoldSource { get; set; }
 }
}
