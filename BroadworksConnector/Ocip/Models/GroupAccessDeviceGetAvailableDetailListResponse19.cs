using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetAvailableDetailListResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice> _availableAccessDevice;

    [XmlElement(ElementName = "availableAccessDevice", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse19AvailableAccessDevice> AvailableAccessDevice {
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
