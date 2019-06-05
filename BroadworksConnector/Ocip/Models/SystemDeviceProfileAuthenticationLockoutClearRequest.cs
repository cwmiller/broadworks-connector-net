using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceProfileAuthenticationLockoutClearRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.AccessDeviceKey> _accessDevice;

    [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AccessDeviceKey> AccessDevice {
        get => _accessDevice;
        set {
            AccessDeviceSpecified = true;
            _accessDevice = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceSpecified { get; set; }
}
}
