using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceTypeGetEnhancedConfigurableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _deviceTypeTable;

    [XmlElement(ElementName = "deviceTypeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTypeTable {
        get => _deviceTypeTable;
        set {
            DeviceTypeTableSpecified = true;
            _deviceTypeTable = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeTableSpecified { get; set; }
}
}
