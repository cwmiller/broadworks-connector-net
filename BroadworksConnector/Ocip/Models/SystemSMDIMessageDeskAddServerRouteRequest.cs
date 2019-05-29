using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskAddServerRouteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "routeDestination", IsNullable = false)]
    public string RouteDestination { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public List<string> DeviceName { get; set; }
 }
}
