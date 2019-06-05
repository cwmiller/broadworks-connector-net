using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementEventGetListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _eventTable;

    [XmlElement(ElementName = "eventTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable EventTable {
        get => _eventTable;
        set {
            EventTableSpecified = true;
            _eventTable = value;
        }
    }

    [XmlIgnore]
    public bool EventTableSpecified { get; set; }
}
}
