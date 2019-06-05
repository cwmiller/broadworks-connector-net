using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetEventDetailListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.ScheduleEvents> _scheduleEvents;

    [XmlElement(ElementName = "scheduleEvents", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ScheduleEvents> ScheduleEvents {
        get => _scheduleEvents;
        set {
            ScheduleEventsSpecified = true;
            _scheduleEvents = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleEventsSpecified { get; set; }
}
}
