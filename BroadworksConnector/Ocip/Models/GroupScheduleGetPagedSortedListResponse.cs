using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _scheduleTable;

    [XmlElement(ElementName = "scheduleTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ScheduleTable {
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
