using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "routePointTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutePointTable { get; set; }
 }
}
