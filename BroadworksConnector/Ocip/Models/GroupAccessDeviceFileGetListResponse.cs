using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

    [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DeviceFilesTable {
        get => _deviceFilesTable;
        set {
            DeviceFilesTableSpecified = true;
            _deviceFilesTable = value;
        }
    }

    [XmlIgnore]
    public bool DeviceFilesTableSpecified { get; set; }
}
}
