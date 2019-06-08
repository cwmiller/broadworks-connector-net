using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHolidayScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _holidayScheduleTable;

    [XmlElement(ElementName = "holidayScheduleTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable HolidayScheduleTable {
        get => _holidayScheduleTable;
        set {
            HolidayScheduleTableSpecified = true;
            _holidayScheduleTable = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleTableSpecified { get; set; }
}
}
