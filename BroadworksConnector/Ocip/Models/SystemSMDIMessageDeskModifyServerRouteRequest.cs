using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskModifyServerRouteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "routeDestination", IsNullable = false)]
    public string RouteDestination { get; set; }
    [XmlElement(ElementName = "deviceNameList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList DeviceNameList { get; set; }
 }
}
