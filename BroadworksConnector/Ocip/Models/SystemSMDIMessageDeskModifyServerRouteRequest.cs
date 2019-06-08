using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskModifyServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList _deviceNameList;

    [XmlElement(ElementName = "deviceNameList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList DeviceNameList {
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
