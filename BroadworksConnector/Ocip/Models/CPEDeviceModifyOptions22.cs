using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CPEDeviceModifyOptions22 
{
    private bool _enableMonitoring;

    [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
    public bool EnableMonitoring {
        get => _enableMonitoring;
        set {
            EnableMonitoringSpecified = true;
            _enableMonitoring = value;
        }
    }

    [XmlIgnore]
    public bool EnableMonitoringSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions22 _deviceManagementDeviceTypeOptions;

    [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions22 DeviceManagementDeviceTypeOptions {
        get => _deviceManagementDeviceTypeOptions;
        set {
            DeviceManagementDeviceTypeOptionsSpecified = true;
            _deviceManagementDeviceTypeOptions = value;
        }
    }

    [XmlIgnore]
    public bool DeviceManagementDeviceTypeOptionsSpecified { get; set; }
}
}
