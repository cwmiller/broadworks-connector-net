using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPolycomPhoneServicesGetPrimaryEndpointListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _deviceUserTable;

    [XmlElement(ElementName = "deviceUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DeviceUserTable {
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
