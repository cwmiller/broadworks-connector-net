using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _scheduleTable;

    [XmlElement(ElementName = "scheduleTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ScheduleTable {
        get => _scheduleTable;
        set {
            ScheduleTableSpecified = true;
            _scheduleTable = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleTableSpecified { get; set; }
}
}
