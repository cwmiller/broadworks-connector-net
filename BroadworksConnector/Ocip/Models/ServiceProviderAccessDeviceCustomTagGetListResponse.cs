using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _deviceCustomTagsTable;

    [XmlElement(ElementName = "deviceCustomTagsTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DeviceCustomTagsTable {
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
