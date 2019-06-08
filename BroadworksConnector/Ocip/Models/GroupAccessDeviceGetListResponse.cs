using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _accessDeviceTable;

    [XmlElement(ElementName = "accessDeviceTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AccessDeviceTable {
        get => _accessDeviceTable;
        set {
            AccessDeviceTableSpecified = true;
            _accessDeviceTable = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceTableSpecified { get; set; }
}
}
