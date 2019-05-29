using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CollaborateRoomSchedule 
{
    [XmlElement(ElementName = "scheduleReservationless", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateRoomScheduleScheduleReservationless ScheduleReservationless { get; set; }
    [XmlElement(ElementName = "scheduleOneTime", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateRoomScheduleScheduleOneTime ScheduleOneTime { get; set; }
    [XmlElement(ElementName = "scheduleRecurring", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateRoomScheduleScheduleRecurring ScheduleRecurring { get; set; }
 }
}
