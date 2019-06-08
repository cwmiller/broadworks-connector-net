using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseDeviceList 
{
    private List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> _device;

    [XmlElement(ElementName = "device", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.EnterpriseAccessDevice> Device {
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
