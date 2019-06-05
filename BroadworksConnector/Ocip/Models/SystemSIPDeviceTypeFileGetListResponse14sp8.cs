using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileGetListResponse14sp8 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _deviceTypeFilesTable;

    [XmlElement(ElementName = "deviceTypeFilesTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTypeFilesTable {
        get => _deviceTypeFilesTable;
        set {
            DeviceTypeFilesTableSpecified = true;
            _deviceTypeFilesTable = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeFilesTableSpecified { get; set; }
}
}
