using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceGetUserListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _deviceUserTable;

    [XmlElement(ElementName = "deviceUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceUserTable {
        get => _deviceUserTable;
        set {
            DeviceUserTableSpecified = true;
            _deviceUserTable = value;
        }
    }

    [XmlIgnore]
    public bool DeviceUserTableSpecified { get; set; }
}
}
