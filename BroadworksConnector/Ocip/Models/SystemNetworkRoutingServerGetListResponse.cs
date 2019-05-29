using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkRoutingServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "networkRoutingServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable NetworkRoutingServerTable { get; set; }
 }
}
