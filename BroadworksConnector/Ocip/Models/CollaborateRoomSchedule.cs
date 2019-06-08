using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CollaborateRoomSchedule 
{
    private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleReservationless _scheduleReservationless;

    [XmlElement(ElementName = "scheduleReservationless", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleReservationless ScheduleReservationless {
        get => _scheduleReservationless;
        set {
            ScheduleReservationlessSpecified = true;
            _scheduleReservationless = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleReservationlessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleOneTime _scheduleOneTime;

    [XmlElement(ElementName = "scheduleOneTime", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleOneTime ScheduleOneTime {
        get => _scheduleOneTime;
        set {
            ScheduleOneTimeSpecified = true;
            _scheduleOneTime = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleOneTimeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleRecurring _scheduleRecurring;

    [XmlElement(ElementName = "scheduleRecurring", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleRecurring ScheduleRecurring {
        get => _scheduleRecurring;
        set {
            ScheduleRecurringSpecified = true;
            _scheduleRecurring = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleRecurringSpecified { get; set; }
}
}
