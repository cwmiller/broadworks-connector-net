using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoamingNetworkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "roamingNetworkTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RoamingNetworkTable { get; set; }
 }
}
