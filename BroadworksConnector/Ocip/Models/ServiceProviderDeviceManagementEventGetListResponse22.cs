using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceManagementEventGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _eventTable;

    [XmlElement(ElementName = "eventTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable EventTable {
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
