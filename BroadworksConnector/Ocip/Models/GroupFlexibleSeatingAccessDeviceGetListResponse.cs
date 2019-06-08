using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingAccessDeviceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice> _availableAccessDevice;

    [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice> AvailableAccessDevice {
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
