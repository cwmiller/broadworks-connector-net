using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupSessionAdmissionControlGetAvailableDeviceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.AccessDevice> _accessDevice;

    [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AccessDevice> AccessDevice {
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
