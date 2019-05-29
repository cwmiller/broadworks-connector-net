using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MeetMeConferencingConferenceSchedule 
{
    [XmlElement(ElementName = "scheduleReservationless", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleReservationless ScheduleReservationless { get; set; }
    [XmlElement(ElementName = "scheduleOneTime", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleOneTime ScheduleOneTime { get; set; }
    [XmlElement(ElementName = "scheduleRecurring", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleRecurring ScheduleRecurring { get; set; }
 }
}
