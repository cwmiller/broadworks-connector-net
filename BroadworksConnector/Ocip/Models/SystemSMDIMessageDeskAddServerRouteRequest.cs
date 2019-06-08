using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskAddServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _routeDestination;

    [XmlElement(ElementName = "routeDestination", IsNullable = false, Namespace = "")]
    public string RouteDestination {
        get => _routeDestination;
        set {
            RouteDestinationSpecified = true;
            _routeDestination = value;
        }
    }

    [XmlIgnore]
    public bool RouteDestinationSpecified { get; set; }
    private List<string> _deviceName;

    [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
    public List<string> DeviceName {
        get => _deviceName;
        set {
            DeviceNameSpecified = true;
            _deviceName = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameSpecified { get; set; }
}
}
