using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementDeviceList 
{
    private List<BroadworksConnector.Ocip.Models.AccessDevice> _device;

    [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AccessDevice> Device {
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
