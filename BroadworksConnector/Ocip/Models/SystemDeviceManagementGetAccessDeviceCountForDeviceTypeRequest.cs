using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceType;

    [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
    public string DeviceType {
        get => _deviceType;
        set {
            DeviceTypeSpecified = true;
            _deviceType = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeSpecified { get; set; }
    private bool _countOnlyResetSupportedDevice;

    [XmlElement(ElementName = "countOnlyResetSupportedDevice", IsNullable = false, Namespace = "")]
    public bool CountOnlyResetSupportedDevice {
        get => _countOnlyResetSupportedDevice;
        set {
            CountOnlyResetSupportedDeviceSpecified = true;
            _countOnlyResetSupportedDevice = value;
        }
    }

    [XmlIgnore]
    public bool CountOnlyResetSupportedDeviceSpecified { get; set; }
    private bool _allowUnmanagedDeviceType;

    [XmlElement(ElementName = "allowUnmanagedDeviceType", IsNullable = false, Namespace = "")]
    public bool AllowUnmanagedDeviceType {
        get => _allowUnmanagedDeviceType;
        set {
            AllowUnmanagedDeviceTypeSpecified = true;
            _allowUnmanagedDeviceType = value;
        }
    }

    [XmlIgnore]
    public bool AllowUnmanagedDeviceTypeSpecified { get; set; }
}
}
