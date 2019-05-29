using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingRealmGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "routingRealmTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutingRealmTable { get; set; }
 }
}
