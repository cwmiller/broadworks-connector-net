using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeGetRequest18sp1V2 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
}
}
