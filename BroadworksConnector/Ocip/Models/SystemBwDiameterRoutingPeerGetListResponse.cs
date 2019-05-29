using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingPeerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "routingPeerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutingPeerTable { get; set; }
 }
}
