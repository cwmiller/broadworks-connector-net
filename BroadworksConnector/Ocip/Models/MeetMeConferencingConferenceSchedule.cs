using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MeetMeConferencingConferenceSchedule 
{
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleReservationless _scheduleReservationless;

    [XmlElement(ElementName = "scheduleReservationless", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleReservationless ScheduleReservationless {
        get => _scheduleReservationless;
        set {
            ScheduleReservationlessSpecified = true;
            _scheduleReservationless = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleReservationlessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleOneTime _scheduleOneTime;

    [XmlElement(ElementName = "scheduleOneTime", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleOneTime ScheduleOneTime {
        get => _scheduleOneTime;
        set {
            ScheduleOneTimeSpecified = true;
            _scheduleOneTime = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleOneTimeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleRecurring _scheduleRecurring;

    [XmlElement(ElementName = "scheduleRecurring", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleRecurring ScheduleRecurring {
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
