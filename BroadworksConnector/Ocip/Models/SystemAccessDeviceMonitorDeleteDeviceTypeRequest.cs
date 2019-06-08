using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceMonitorDeleteDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _deleteAllDeviceTypes;

    [XmlElement(ElementName = "deleteAllDeviceTypes", IsNullable = false, Namespace = "")]
    public bool DeleteAllDeviceTypes {
        get => _deleteAllDeviceTypes;
        set {
            DeleteAllDeviceTypesSpecified = true;
            _deleteAllDeviceTypes = value;
        }
    }

    [XmlIgnore]
    public bool DeleteAllDeviceTypesSpecified { get; set; }
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
