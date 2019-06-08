using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMGCPDeviceTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeTable;

    [XmlElement(ElementName = "deviceTypeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTypeTable {
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
