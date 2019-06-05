using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceCustomTagGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _deviceCustomTagsTable;

    [XmlElement(ElementName = "deviceCustomTagsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceCustomTagsTable {
        get => _deviceCustomTagsTable;
        set {
            DeviceCustomTagsTableSpecified = true;
            _deviceCustomTagsTable = value;
        }
    }

    [XmlIgnore]
    public bool DeviceCustomTagsTableSpecified { get; set; }
}
}
