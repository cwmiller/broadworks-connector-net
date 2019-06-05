using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeServiceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _supportsPolycomPhoneServices;

    [XmlElement(ElementName = "supportsPolycomPhoneServices", IsNullable = false, Namespace = "")]
    public bool SupportsPolycomPhoneServices {
        get => _supportsPolycomPhoneServices;
        set {
            SupportsPolycomPhoneServicesSpecified = true;
            _supportsPolycomPhoneServices = value;
        }
    }

    [XmlIgnore]
    public bool SupportsPolycomPhoneServicesSpecified { get; set; }
}
}
