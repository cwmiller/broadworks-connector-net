using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMGCPDeviceTypeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _isObsolete;

    [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
    public bool IsObsolete {
        get => _isObsolete;
        set {
            IsObsoleteSpecified = true;
            _isObsolete = value;
        }
    }

    [XmlIgnore]
    public bool IsObsoleteSpecified { get; set; }
}
}
