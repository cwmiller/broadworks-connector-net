using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTimeScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _timeScheduleTable;

    [XmlElement(ElementName = "timeScheduleTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TimeScheduleTable {
        get => _timeScheduleTable;
        set {
            TimeScheduleTableSpecified = true;
            _timeScheduleTable = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleTableSpecified { get; set; }
}
}
