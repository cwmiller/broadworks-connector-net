using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetDNISAnnouncementResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead20 MediaOnHoldSource { get; set; }
 }
}
