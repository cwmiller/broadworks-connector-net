using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceMonitorAddDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _addAllDeviceTypes;

    [XmlElement(ElementName = "addAllDeviceTypes", IsNullable = false, Namespace = "")]
    public bool AddAllDeviceTypes {
        get => _addAllDeviceTypes;
        set {
            AddAllDeviceTypesSpecified = true;
            _addAllDeviceTypes = value;
        }
    }

    [XmlIgnore]
    public bool AddAllDeviceTypesSpecified { get; set; }
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
}
}
