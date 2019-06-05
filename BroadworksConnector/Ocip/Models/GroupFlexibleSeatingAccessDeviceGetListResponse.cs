using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingAccessDeviceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice> _availableAccessDevice;

    [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice> AvailableAccessDevice {
        get => _availableAccessDevice;
        set {
            AvailableAccessDeviceSpecified = true;
            _availableAccessDevice = value;
        }
    }

    [XmlIgnore]
    public bool AvailableAccessDeviceSpecified { get; set; }
}
}
