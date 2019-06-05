using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHolidayScheduleDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _holidayScheduleName;

    [XmlElement(ElementName = "holidayScheduleName", IsNullable = false, Namespace = "")]
    public string HolidayScheduleName {
        get => _holidayScheduleName;
        set {
            HolidayScheduleNameSpecified = true;
            _holidayScheduleName = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleNameSpecified { get; set; }
}
}
