using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTimeScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _timeSchedule;

    [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
    public List<string> TimeSchedule {
        get => _timeSchedule;
        set {
            TimeScheduleSpecified = true;
            _timeSchedule = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleSpecified { get; set; }
}
}
