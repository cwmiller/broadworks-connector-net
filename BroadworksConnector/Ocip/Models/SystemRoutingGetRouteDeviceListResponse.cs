using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetRouteDeviceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "routeDeviceTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RouteDeviceTable { get; set; }
 }
}
