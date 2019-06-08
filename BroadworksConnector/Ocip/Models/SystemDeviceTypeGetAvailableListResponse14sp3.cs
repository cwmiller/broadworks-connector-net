using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse14sp3TypeInfo> _typeInfo;

    [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse14sp3TypeInfo> TypeInfo {
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
