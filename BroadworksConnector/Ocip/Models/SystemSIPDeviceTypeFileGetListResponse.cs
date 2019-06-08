using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeFilesTable;

    [XmlElement(ElementName = "deviceTypeFilesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTypeFilesTable {
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
