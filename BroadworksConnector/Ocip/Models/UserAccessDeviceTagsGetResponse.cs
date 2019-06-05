using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAccessDeviceTagsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _deviceTagsTable;

    [XmlElement(ElementName = "deviceTagsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTagsTable {
        get => _deviceTagsTable;
        set {
            DeviceTagsTableSpecified = true;
            _deviceTagsTable = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTagsTableSpecified { get; set; }
}
}
