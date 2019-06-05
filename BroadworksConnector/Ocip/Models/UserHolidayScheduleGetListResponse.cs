using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHolidayScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _holidayScheduleTable;

    [XmlElement(ElementName = "holidayScheduleTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable HolidayScheduleTable {
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
