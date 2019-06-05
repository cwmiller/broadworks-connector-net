using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskModifyServerRouteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList _deviceNameList;

    [XmlElement(ElementName = "deviceNameList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList DeviceNameList {
        get => _deviceNameList;
        set {
            DeviceNameListSpecified = true;
            _deviceNameList = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameListSpecified { get; set; }
}
}
