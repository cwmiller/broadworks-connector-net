using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceFileGetListResponse14sp8 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _deviceFilesTable;

    [XmlElement(ElementName = "deviceFilesTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceFilesTable {
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
