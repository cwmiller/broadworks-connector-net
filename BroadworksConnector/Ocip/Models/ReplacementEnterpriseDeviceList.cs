using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseDeviceList 
{
    private List<BroadworksConnector.Ocip.Models.EnterpriseAccessDevice> _device;

    [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.EnterpriseAccessDevice> Device {
        get => _device;
        set {
            DeviceSpecified = true;
            _device = value;
        }
    }

    [XmlIgnore]
    public bool DeviceSpecified { get; set; }
}
}
