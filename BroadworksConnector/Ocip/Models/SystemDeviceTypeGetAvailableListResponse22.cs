using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _deviceType;

    [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
    public List<string> DeviceType {
        get => _deviceType;
        set {
            DeviceTypeSpecified = true;
            _deviceType = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse22TypeInfo> _typeInfo;

    [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse22TypeInfo> TypeInfo {
        get => _typeInfo;
        set {
            TypeInfoSpecified = true;
            _typeInfo = value;
        }
    }

    [XmlIgnore]
    public bool TypeInfoSpecified { get; set; }
}
}
